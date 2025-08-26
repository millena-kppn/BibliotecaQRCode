using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmEmprestimoEditar : Form
    {
        private int? emprestimoId; // se null = novo, se tiver valor = edição

        public FrmEmprestimoEditar(int? id = null)
        {
            InitializeComponent();
            emprestimoId = id;
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (var db = new BibliotecaContext())
            {
                // Carregar alunos
                cbAluno.DataSource = db.Alunos.ToList();
                cbAluno.DisplayMember = "Nome";
                cbAluno.ValueMember = "Id";

                // Carregar livros
                cbLivro.DataSource = db.Livros.ToList();
                cbLivro.DisplayMember = "Titulo";
                cbLivro.ValueMember = "Id";
            }

            // Carregar opções de status
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Ativo");
            cbStatus.Items.Add("Devolvido");

            if (emprestimoId.HasValue)
            {
                using (var db = new BibliotecaContext())
                {
                    var emp = db.Emprestimos.Find(emprestimoId.Value);
                    if (emp != null)
                    {
                        cbAluno.SelectedValue = emp.AlunoId;
                        cbLivro.SelectedValue = emp.LivroId;
                        dtpEmprestimo.Value = emp.DataEmprestimo;
                        dtpDevolucao.Value = emp.DataDevolucao ?? DateTime.Now;
                        cbStatus.SelectedItem = emp.Status;
                    }
                }
            }
            else
            {
                dtpEmprestimo.Value = DateTime.Now;
                dtpDevolucao.Value = DateTime.Now.AddDays(7); // padrão 7 dias
                cbStatus.SelectedIndex = 0;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                Emprestimo emp;

                if (emprestimoId.HasValue)
                {
                    emp = db.Emprestimos.Find(emprestimoId.Value);
                    if (emp == null) return;
                }
                else
                {
                    emp = new Emprestimo();
                    db.Emprestimos.Add(emp);
                }

                emp.AlunoId = (int)cbAluno.SelectedValue;
                emp.LivroId = (int)cbLivro.SelectedValue;
                emp.DataEmprestimo = dtpEmprestimo.Value;
                emp.DataDevolucao = dtpDevolucao.Value;
                emp.Status = cbStatus.SelectedItem.ToString();

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}


