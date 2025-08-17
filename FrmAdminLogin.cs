using System;
using System.Windows.Forms;

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
            string senhaCorreta = "admin123"; // depois pode colocar em config ou BD

            if (txtSenha.Text == senhaCorreta)
            {
                Hide();
                new FrmAdmin().ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtSenha.Focus();
            }
        }
    }
}
