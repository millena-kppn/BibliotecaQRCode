using System;
using System.Windows.Forms;

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
        }
        //aqui
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
