using System;
using System.Windows.Forms;
using BibliotecaQRCode.Data;

namespace BibliotecaQRCode
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnEntrar;
            this.CancelButton = btnCancelar;
        }
        //aqui
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            // Simples por enquanto. Depois movemos para BD/config.
            const string senhaCorreta = "admin123";

            if (txtSenha.Text == senhaCorreta)
            {
                Hide();
                new FrmAdmin().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Acesso negado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }
            string login = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (var db = new BibliotecaContext())
            {
                var admin = db.Admins
                    .FirstOrDefault(a => a.Login == login && a.Senha == senha);

                if (admin != null)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FrmAdmin frm = new FrmAdmin();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //aqui
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaContext())
            {
                // Pega o primeiro admin (já que você disse que só tem um)
                var admin = db.Admins.FirstOrDefault();

                if (admin != null)
                {
                    // Gerar um novo código simples (6 dígitos)
                    string novoCodigo = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

                    admin.Senha = novoCodigo;
                    db.SaveChanges();

                    MessageBox.Show($"Seu novo código de acesso é: {novoCodigo}",
                        "Recuperação de Senha",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhum administrador encontrado!",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

    }
}
