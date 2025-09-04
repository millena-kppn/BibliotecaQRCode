using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmAdmin : Form
    {
        private string entidadeAtual = "";

        public FrmAdmin()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        // ==============================
        // MÉTODOS DE CARREGAMENTO
        // ==============================
        private void CarregarLivros()
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Livros
                    .Select(l => new { l.Id, l.Titulo, l.Autor, l.CodigoQR })
                    .ToList();
            }
            entidadeAtual = "Livro";
        }

        private void CarregarAlunos()
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Alunos
                    .Select(a => new { a.Id, a.Nome, a.Matricula, a.Curso })
                    .ToList();
            }
            entidadeAtual = "Aluno";
        }

        private void CarregarEmprestimos()
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Emprestimos
                    .Select(emp => new
                    {
                        emp.Id,
                        Livro = emp.Livro.Titulo,
                        Aluno = emp.Aluno.Nome,
                        emp.DataEmprestimo,
                        emp.DataDevolucao,
                        emp.Status
                    })
                    .ToList();
            }
            entidadeAtual = "Emprestimo";
        }

        // ==============================
        // CONFIGURAÇÃO DO GRID
        // ==============================
        private void ConfigurarGrid()
        {
            dgvDados.AutoGenerateColumns = true;
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.MultiSelect = false;
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RecarregarGrid()
        {
            if (entidadeAtual == "Livro") CarregarLivros();
            else if (entidadeAtual == "Aluno") CarregarAlunos();
            else if (entidadeAtual == "Emprestimo") CarregarEmprestimos();
        }

        // ==============================
        // BOTÕES DE SELEÇÃO
        // ==============================
        private void btnAlunos_Click_1(object sender, EventArgs e)
        {
            CarregarAlunos();
        }

        private void btnLivros_Click_1(object sender, EventArgs e)
        {
            CarregarLivros();
        }

        private void btnEmprestimos_Click_1(object sender, EventArgs e)
        {
            CarregarEmprestimos();
        }

        // ==============================
        // BOTÃO ADICIONAR
        // ==============================
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entidadeAtual))
            {
                MessageBox.Show("Escolha primeiro: Livros, Alunos ou Empréstimos.");
                return;
            }

            if (entidadeAtual == "Livro")
            {
                var dlg = new FrmLivroEditar();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new BibliotecaContext())
                    {
                        var novo = new Livro
                        {
                            Titulo = dlg.Titulo,
                            Autor = dlg.Autor,
                            CodigoQR = dlg.CodigoQR
                        };
                        db.Livros.Add(novo);
                        db.SaveChanges();
                    }
                    RecarregarGrid();
                }
            }
            else if (entidadeAtual == "Aluno")
            {
                var dlg = new FrmAlunoEditar();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new BibliotecaContext())
                    {
                        var novo = new Aluno
                        {
                            Nome = dlg.Nome,
                            Matricula = dlg.Matricula
                        };
                        db.Alunos.Add(novo);
                        db.SaveChanges();
                    }
                    RecarregarGrid();
                }
            }
            else if (entidadeAtual == "Emprestimo")
            {
                using (var dlg = new FrmEmprestimoEditar())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        CarregarEmprestimos();
                }
            }
        }

        // ==============================
        // BOTÃO EDITAR
        // ==============================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro.");
                return;
            }

            int id = (int)dgvDados.CurrentRow.Cells["Id"].Value;

            if (entidadeAtual == "Livro")
            {
                using (var db = new BibliotecaContext())
                {
                    var livro = db.Livros.Find(id);
                    if (livro == null) return;

                    var dlg = new FrmLivroEditar(livro);
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        livro.Titulo = dlg.Titulo;
                        livro.Autor = dlg.Autor;
                        livro.CodigoQR = dlg.CodigoQR;
                        db.SaveChanges();
                    }
                }
                RecarregarGrid();
            }
            else if (entidadeAtual == "Aluno")
            {
                using (var db = new BibliotecaContext())
                {
                    var aluno = db.Alunos.Find(id);
                    if (aluno == null) return;

                    var dlg = new FrmAlunoEditar(aluno);
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        aluno.Nome = dlg.Nome;
                        aluno.Matricula = dlg.Matricula;
                        db.SaveChanges();
                    }
                }
                RecarregarGrid();
            }
            else if (entidadeAtual == "Emprestimo")
            {
                using (var dlg = new FrmEmprestimoEditar(id))
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        CarregarEmprestimos();
                }
            }
        }

        // ==============================
        // BOTÃO EXCLUIR
        // ==============================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow == null)
            {
                MessageBox.Show("Selecione um registro.");
                return;
            }

            int id = (int)dgvDados.CurrentRow.Cells["Id"].Value;

            var ok = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ok != DialogResult.Yes) return;

            using (var db = new BibliotecaContext())
            {
                if (entidadeAtual == "Livro")
                {
                    var livro = db.Livros.Find(id);
                    if (livro != null) db.Livros.Remove(livro);
                }
                else if (entidadeAtual == "Aluno")
                {
                    var aluno = db.Alunos.Find(id);
                    if (aluno != null) db.Alunos.Remove(aluno);
                }
                else if (entidadeAtual == "Emprestimo")
                {
                    var emp = db.Emprestimos.Find(id);
                    if (emp != null) db.Emprestimos.Remove(emp);
                }

                db.SaveChanges();
            }
            RecarregarGrid();
        }
    }
}
//corrigido 
