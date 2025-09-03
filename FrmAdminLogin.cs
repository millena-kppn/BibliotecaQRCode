
//aqui
using System;
using System.Linq;
using System.Windows.Forms;
using BibliotecaQRCode.Data;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text?.Trim();
            var token = txtSenha.Text?.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Informe login e senha (ou código de recuperação).", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var db = new BibliotecaContext();
            var admin = db.Admins.FirstOrDefault(a => a.Login == login);
            if (admin == null)
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool senhaOk = token == admin.Senha;

            bool codigoOk = false;
            if (!string.IsNullOrEmpty(admin.CodigoRecuperacao) && admin.ExpiraCodigo.HasValue)
            {
                codigoOk = token == admin.CodigoRecuperacao && admin.ExpiraCodigo.Value >= DateTime.Now;
            }

            if (!senhaOk && !codigoOk)
            {
                MessageBox.Show("Senha ou código inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se entrou com código de recuperação, inválide-o (one-time)
            if (codigoOk)
            {
                admin.CodigoRecuperacao = null;
                admin.ExpiraCodigo = null;
                db.SaveChanges();
            }

            // Login OK -> abrir FrmAdmin
            Hide();
            using (var frm = new FrmAdmin())
            {
                frm.ShowDialog(this);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text?.Trim();
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Digite o login do administrador para gerar o código.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
                return;
            }

            using var db = new BibliotecaContext();
            var admin = db.Admins.FirstOrDefault(a => a.Login == login);
            if (admin == null)
            {
                MessageBox.Show("Administrador não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string codigo = GerarCodigo(6);
            admin.CodigoRecuperacao = codigo;
            admin.ExpiraCodigo = DateTime.Now.AddMinutes(10);
            db.SaveChanges();

            MessageBox.Show(
                $"Código de recuperação gerado:\n\n{codigo}\n\nVálido até {admin.ExpiraCodigo:dd/MM/yyyy HH:mm}",
                "Código gerado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // colocar foco para inserir código
            txtSenha.Focus();
            txtSenha.SelectAll();
        }

        private static string GerarCodigo(int tamanho)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // sem I,O,1,0
            var rnd = new Random();
            return new string(Enumerable.Range(0, tamanho).Select(_ => chars[rnd.Next(chars.Length)]).ToArray());
        }
    }
}

