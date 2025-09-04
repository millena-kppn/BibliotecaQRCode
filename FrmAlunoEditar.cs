using System;
using System.Windows.Forms;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmAlunoEditar : Form
    {
        // Propriedades públicas
        public string Nome { get; private set; }
        public string Matricula { get; private set; }

        public FrmAlunoEditar()
        {
            InitializeComponent();
        }

        // Construtor para edição
        public FrmAlunoEditar(Aluno aluno) : this()
        {
            txtNome.Text = aluno.Nome;
            txtMatricula.Text = aluno.Matricula;
            cmbCurso.SelectedItem?.ToString();
        }
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Nome = txtNome.Text;
            Matricula = txtMatricula.Text;

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
