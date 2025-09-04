namespace BibliotecaQRCode
{
    partial class FrmAlunoEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            lblAluno = new Label();
            lblMatricula = new Label();
            cmbCurso = new ComboBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(215, 110);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(215, 163);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(324, 256);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(434, 256);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Location = new Point(215, 92);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(39, 15);
            lblAluno.TabIndex = 4;
            lblAluno.Text = "Aluno";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(216, 145);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 5;
            lblMatricula.Text = "Matricula";
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "Administração", "Ciência da Computação", "Direito", "Jornalismo", "Medicina", "Analise e Desenvolvimento de Sistemas" });
            cmbCurso.Location = new Point(369, 145);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(171, 23);
            cmbCurso.TabIndex = 6;
            // 
            // FrmAlunoEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbCurso);
            Controls.Add(lblMatricula);
            Controls.Add(lblAluno);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtMatricula);
            Controls.Add(txtNome);
            Name = "FrmAlunoEditar";
            Text = "FrmAlunoEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtMatricula;
        private Button btnOK;
        private Button btnCancelar;
        private Label lblAluno;
        private Label lblMatricula;
        private ComboBox cmbCurso;
    }
}