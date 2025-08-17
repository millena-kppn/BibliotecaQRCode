using System;
using System.Linq;
using System.Windows.Forms;

namespace BibliotecaQRCode
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Alunos.ToList();
            }
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Livros.ToList();
            }
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                dgvDados.DataSource = db.Emprestimos
                    .Select(e => new
                    {
                        e.Id,
                        Aluno = e.Aluno.Nome,
                        Livro = e.Livro.Titulo,
                        e.DataEmprestimo,
                        e.DataDevolucao
                    })
                    .ToList();
            }
        }
    }
}