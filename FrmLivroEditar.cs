using System;
using System.Windows.Forms;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmLivroEditar : Form
    {
        // Propriedades públicas para receber/enviar dados
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string CodigoQR { get; private set; }

        public FrmLivroEditar()
        {
            InitializeComponent();
        }
        // Construtor que recebe um livro para edição
        public FrmLivroEditar(Livro livro) : this()
        {
            txtTitulo.Text = livro.Titulo;
            txtAutor.Text = livro.Autor;
            txtCodigoQR.Text = livro.CodigoQR;
        }
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Titulo = txtTitulo.Text;
            Autor = txtAutor.Text;
            CodigoQR = txtCodigoQR.Text;

            DialogResult = DialogResult.OK;
            Close();

        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}


