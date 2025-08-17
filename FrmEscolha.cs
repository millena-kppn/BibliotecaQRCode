using System;
using System.Windows.Forms;

namespace BibliotecaQRCode
{
    public partial class FrmEscolha : Form
    {
        public FrmEscolha()
        {
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmLogin().ShowDialog();
            Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmAdminLogin().ShowDialog();
            Show();
        }
    }
}

