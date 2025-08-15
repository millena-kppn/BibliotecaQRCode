using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;

namespace BibliotecaQRCode
{
    public partial class FrmDevolucao : Form
    {
        public FrmDevolucao() => InitializeComponent();

        private void txtCodigoQR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ProcessarDevolucao(txtCodigoQR.Text.Trim());
                txtCodigoQR.Clear();
            }
        }

        private void ProcessarDevolucao(string codigoQR)
        {
            if (string.IsNullOrWhiteSpace(codigoQR)) return;

            using var db = new BibliotecaContext();

            var livro = db.Livros.FirstOrDefault(l => l.CodigoQR == codigoQR);
            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.");
                return;
            }

            var emprestimo = db.Emprestimos
                .Where(e => e.LivroId == livro.Id && e.Status == "Em andamento")
                .OrderByDescending(e => e.DataEmprestimo)
                .FirstOrDefault();

            if (emprestimo == null)
            {
                MessageBox.Show("Não há empréstimo em andamento para este livro.");
                return;
            }

            emprestimo.Status = "Devolvido";
            db.SaveChanges();

            MessageBox.Show($"Devolução registrada!\nLivro: {livro.Titulo}");
        }
    }
}
