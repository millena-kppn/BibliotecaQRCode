using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;

namespace BibliotecaQRCode
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            PrepararGrid();
        }

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
        //aqui
        private void btnAlunos_Click_1(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Alunos
                    .OrderBy(a => a.Nome)
                    .ToList();
            }
        }
        //aqui
        private void btnLivros_Click_1(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Livros
                    .OrderBy(l => l.Titulo)
                    .ToList();
            }
        }
        //aqui
        private void btnEmprestimos_Click_1(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Emprestimos
                    .Select(emp => new
                    {
                        emp.Id,
                        Aluno = emp.Aluno != null ? emp.Aluno.Nome : "Desconhecido",
                        Livro = emp.Livro != null ? emp.Livro.Titulo : "Desconhecido",
                        emp.DataEmprestimo,
                        emp.DataDevolucao
                    })
                    .OrderBy(e => e.DataEmprestimo)
                    .ToList();
            }
        }
    }
}
