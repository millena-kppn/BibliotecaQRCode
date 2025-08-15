using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmEmprestimo : Form
    {
        private readonly Aluno _aluno;

        public FrmEmprestimo(Aluno aluno)
        {
            InitializeComponent();
            _aluno = aluno;
        }

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            lblAluno.Text = $"Aluno: {_aluno.Nome} ({_aluno.Matricula})";
            txtCodigoQR.Focus();
        }

        private bool AlunoTemAtraso()
        {
            using var db = new BibliotecaContext();
            var agora = DateTime.Now;
            return db.Emprestimos.Any(e =>
                e.AlunoId == _aluno.Id &&
                e.Status == "Em andamento" &&
                e.DataDevolucao < agora);
        }

        // scanners costumam enviar ENTER ao final da leitura
        private void txtCodigoQR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita beep
                ProcessarCodigo(txtCodigoQR.Text.Trim());
                txtCodigoQR.Clear();
            }
        }

        private void ProcessarCodigo(string codigoQR)
        {
            if (string.IsNullOrWhiteSpace(codigoQR)) return;

            using var db = new BibliotecaContext();

            // 1) Bloqueio por atraso
            if (AlunoTemAtraso())
            {
                MessageBox.Show("Você possui empréstimos atrasados e não pode pegar novos livros.");
                return;
            }

            // 2) Buscar livro pelo QR
            var livro = db.Livros.FirstOrDefault(l => l.CodigoQR == codigoQR);
            if (livro == null)
            {
                MessageBox.Show("Livro não encontrado.");
                return;
            }

            // (opcional) impedir pegar o mesmo livro se já está em andamento
            bool jaEmprestado = db.Emprestimos.Any(e =>
                e.LivroId == livro.Id && e.Status == "Em andamento");
            if (jaEmprestado)
            {
                MessageBox.Show("Este livro já está emprestado a outra pessoa.");
                return;
            }

            // 3) Registrar empréstimo
            var hoje = DateTime.Now;
            var devolucao = hoje.AddDays(7); // regra simples: 7 dias

            db.Emprestimos.Add(new Emprestimo
            {
                AlunoId = _aluno.Id,
                LivroId = livro.Id,
                DataEmprestimo = hoje,
                DataDevolucao = devolucao,
                Status = "Em andamento"
            });
            db.SaveChanges();

            MessageBox.Show($"Empréstimo registrado!\n\nLivro: {livro.Titulo}\nDevolver até: {devolucao:dd/MM/yyyy}");
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            new FrmDevolucao().ShowDialog();
        }
    }
}
