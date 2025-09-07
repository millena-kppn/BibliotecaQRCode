//aqui
using System;
using System.Windows.Forms;
using BibliotecaQRCode.Models;

namespace BibliotecaQRCode
{
    public partial class FrmAlunoEditar : Form
    {
        private readonly Aluno? _aluno;

        public string Nome => txtNome.Text.Trim();
        public string Matricula => txtMatricula.Text.Trim();
        public string Curso => txtCurso.Text.Trim();

        public FrmAlunoEditar()
        {
            InitializeComponent();
        }

        public FrmAlunoEditar(Aluno aluno) : this()
        {
            _aluno = aluno;
            txtNome.Text = aluno.Nome;
            txtMatricula.Text = aluno.Matricula;
            txtCurso.Text = aluno.Curso ?? string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                MessageBox.Show("Informe o nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Matricula))
            {
                MessageBox.Show("Informe a matrícula.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return;
            }

            // Se chegou até aqui, ok
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
