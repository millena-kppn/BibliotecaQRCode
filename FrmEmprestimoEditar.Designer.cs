namespace BibliotecaQRCode
{
    partial class FrmEmprestimoEditar
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
            cbAluno = new ComboBox();
            cbLivro = new ComboBox();
            lblAluno = new Label();
            lblLivro = new Label();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            lblDataemprestimo = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            dtpEmprestimo = new DateTimePicker();
            lblDevolucao = new Label();
            dtpDevolucao = new DateTimePicker();
            SuspendLayout();
            // 
            // cbAluno
            // 
            cbAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAluno.FormattingEnabled = true;
            cbAluno.Location = new Point(156, 114);
            cbAluno.Name = "cbAluno";
            cbAluno.Size = new Size(194, 33);
            cbAluno.TabIndex = 0;
            // 
            // cbLivro
            // 
            cbLivro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLivro.FormattingEnabled = true;
            cbLivro.Location = new Point(156, 193);
            cbLivro.Name = "cbLivro";
            cbLivro.Size = new Size(194, 33);
            cbLivro.TabIndex = 1;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Location = new Point(156, 86);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(62, 25);
            lblAluno.TabIndex = 3;
            lblAluno.Text = "Aluno";
            // 
            // lblLivro
            // 
            lblLivro.AutoSize = true;
            lblLivro.Location = new Point(160, 162);
            lblLivro.Name = "lblLivro";
            lblLivro.Size = new Size(53, 25);
            lblLivro.TabIndex = 4;
            lblLivro.Text = "Livro";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(160, 236);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(156, 264);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(194, 33);
            cbStatus.TabIndex = 2;
            // 
            // lblDataemprestimo
            // 
            lblDataemprestimo.AutoSize = true;
            lblDataemprestimo.Location = new Point(462, 86);
            lblDataemprestimo.Name = "lblDataemprestimo";
            lblDataemprestimo.Size = new Size(156, 25);
            lblDataemprestimo.TabIndex = 6;
            lblDataemprestimo.Text = "Data empréstimo";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(462, 379);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 37);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(588, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dtpEmprestimo
            // 
            dtpEmprestimo.Location = new Point(462, 114);
            dtpEmprestimo.Name = "dtpEmprestimo";
            dtpEmprestimo.Size = new Size(321, 33);
            dtpEmprestimo.TabIndex = 10;
            // 
            // lblDevolucao
            // 
            lblDevolucao.AutoSize = true;
            lblDevolucao.Location = new Point(462, 162);
            lblDevolucao.Name = "lblDevolucao";
            lblDevolucao.Size = new Size(145, 25);
            lblDevolucao.TabIndex = 11;
            lblDevolucao.Text = "Data Devolução";
            // 
            // dtpDevolucao
            // 
            dtpDevolucao.Location = new Point(462, 193);
            dtpDevolucao.Name = "dtpDevolucao";
            dtpDevolucao.Size = new Size(321, 33);
            dtpDevolucao.TabIndex = 12;
            // 
            // FrmEmprestimoEditar
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDevolucao);
            Controls.Add(lblDevolucao);
            Controls.Add(dtpEmprestimo);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblDataemprestimo);
            Controls.Add(lblStatus);
            Controls.Add(lblLivro);
            Controls.Add(lblAluno);
            Controls.Add(cbStatus);
            Controls.Add(cbLivro);
            Controls.Add(cbAluno);
            Name = "FrmEmprestimoEditar";
            Text = "FrmEmprestimoEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAluno;
        private ComboBox cbLivro;
        private Label lblAluno;
        private Label lblLivro;
        private Label lblStatus;
        private ComboBox cbStatus;
        private Label lblDataemprestimo;
        private Button btnSalvar;
        private Button btnCancelar;
        private DateTimePicker dtpEmprestimo;
        private Label lblDevolucao;
        private DateTimePicker dtpDevolucao;
    }
}