//using System;
//using System.Linq;
//using System.Windows.Forms;
//using BibliotecaQRCode.Data;

//namespace BibliotecaQRCode
//{
//    public partial class FrmDevolucao : Form
//    {
//        public FrmDevolucao() => InitializeComponent();
//        //aqui
//        private void txtCodigoQR_KeyDown_1(object sender, KeyEventArgs e)
//        {
//            if (e.KeyCode == Keys.Enter)
//            {
//                e.SuppressKeyPress = true;
//                ProcessarDevolucao(txtCodigoQR.Text.Trim());
//                txtCodigoQR.Clear();
//            }
//        }
//        //ate aqui
//        private void ProcessarDevolucao(string codigoQR)
//        {
//            if (string.IsNullOrWhiteSpace(codigoQR)) return;

//            using var db = new BibliotecaContext();

//            var livro = db.Livros.FirstOrDefault(l => l.CodigoQR == codigoQR);
//            if (livro == null)
//            {
//                MessageBox.Show("Livro não encontrado.");
//                return;
//            }

//            var emprestimo = db.Emprestimos
//                .Where(e => e.LivroId == livro.Id && e.Status == "Em andamento")
//                .OrderByDescending(e => e.DataEmprestimo)
//                .FirstOrDefault();

//            if (emprestimo == null)
//            {
//                MessageBox.Show("Não há empréstimo em andamento para este livro.");
//                return;
//            }
//            // Verifica se o livro já foi devolvido
//            emprestimo.DataDevolucao = DateTime.Now;
//            emprestimo.Status = "Devolvido";

//            db.SaveChanges();

//            MessageBox.Show($"Devolução registrada!\nLivro: {livro.Titulo}");
//        }
//        private void btnDevolver_Click(object sender, EventArgs e)
//        {
//            //chamando o método ProcessarDevolucao com o texto do TextBox só que para o botão
//            var codigoQR = txtCodigoQR.Text.Trim();
//            ProcessarDevolucao(codigoQR);
//            txtCodigoQR.Clear();
//        }
//    }
//}
//aqui
using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;

namespace BibliotecaQRCode
{
    public partial class FrmDevolucao : Form
    {
        public FrmDevolucao()
        {
            InitializeComponent();
        }

        // Evento ao apertar Enter no TextBox
        private void txtCodigoQR_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita beep
                ProcessarDevolucao(txtCodigoQR.Text.Trim());
                txtCodigoQR.Clear();
            }
        }

        // Evento ao clicar no botão Devolver
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var codigoQR = txtCodigoQR.Text.Trim();
            ProcessarDevolucao(codigoQR);
            txtCodigoQR.Clear();
        }

        // Método que processa a devolução do livro
        private void ProcessarDevolucao(string codigoQR)
        {
            if (string.IsNullOrWhiteSpace(codigoQR)) return;

            using var db = new BibliotecaContext();

            // Busca o livro pelo código QR
            var livro = db.Livros.FirstOrDefault(l => l.CodigoQR == codigoQR);
            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca o empréstimo em andamento mais recente
            var emprestimo = db.Emprestimos
                .Where(e => e.LivroId == livro.Id && e.Status == "Em andamento")
                .OrderByDescending(e => e.DataEmprestimo)
                .FirstOrDefault();

            if (emprestimo == null)
            {
                MessageBox.Show("Não há empréstimo em andamento para este livro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Processa a devolução
            emprestimo.DataDevolucao = DateTime.Now;
            emprestimo.Status = "Devolvido";

            db.SaveChanges();

            MessageBox.Show($"Devolução registrada!\nLivro: {livro.Titulo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
