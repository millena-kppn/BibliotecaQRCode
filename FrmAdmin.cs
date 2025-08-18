using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;

namespace BibliotecaQRCode
{
    public partial class FrmAdmin : Form
    {
        // Variável para armazenar a entidade atual (Alunos, Livros, Empréstimos)
        private string entidadeAtual = "";

        public FrmAdmin()
        {
            InitializeComponent();
            PrepararGrid(); // chamar configuração do DataGridView
        }

        // MÉTODOS DE CARREGAMENTO

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
                    .Select(a => new { a.Id, a.Nome, a.Matricula })
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

        // Configuração inicial do DataGridView
        private void PrepararGrid()
        {
            dgvDados.AutoGenerateColumns = true;
            dgvDados.ReadOnly = true;
            dgvDados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDados.MultiSelect = false;
            dgvDados.AllowUserToAddRows = false;
            dgvDados.AllowUserToDeleteRows = false;
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        // MÉTODOS DE AÇÃO
        // BOTÕES
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

        //Adicionar Registro
        //private void btnAdicionar_Click(object sender, EventArgs e)
        //{

        //}
        ///VERIFICAR PARA CONTINUAR DESENVOLVENDO
    }
}
