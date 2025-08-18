using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmLogin : Form
    {
        public FrmLogin() => InitializeComponent();
        //aqui
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            var matricula = txtMatricula.Text.Trim();
            if (string.IsNullOrWhiteSpace(matricula))
            {
                MessageBox.Show("Informe a matrícula.");
                return;
            }

            using var db = new BibliotecaContext();
            var aluno = db.Alunos.FirstOrDefault(a => a.Matricula == matricula);

            if (aluno == null)
            {
                MessageBox.Show("Aluno não encontrado.");
                return;
            }
            // abre a tela de empréstimo com o aluno logado
            Hide();
            new FrmEmprestimo(aluno).ShowDialog();
            Show();
        }
        //ate aqui
    }
}
