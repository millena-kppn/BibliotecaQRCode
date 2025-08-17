namespace BibliotecaQRCode
{
    partial class FrmAdmin
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
            btnAlunos = new Button();
            btnLivros = new Button();
            btnEmprestimos = new Button();
            dgvDados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnAlunos
            // 
            btnAlunos.Location = new Point(12, 98);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(113, 81);
            btnAlunos.TabIndex = 0;
            btnAlunos.Text = "Alunos";
            btnAlunos.UseVisualStyleBackColor = true;
            // 
            // btnLivros
            // 
            btnLivros.Location = new Point(12, 185);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(113, 81);
            btnLivros.TabIndex = 1;
            btnLivros.Text = "Livros";
            btnLivros.UseVisualStyleBackColor = true;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.Location = new Point(12, 272);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(113, 81);
            btnEmprestimos.TabIndex = 2;
            btnEmprestimos.Text = "Empréstimos";
            btnEmprestimos.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(131, 12);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(657, 426);
            dgvDados.TabIndex = 3;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDados);
            Controls.Add(btnEmprestimos);
            Controls.Add(btnLivros);
            Controls.Add(btnAlunos);
            Name = "FrmAdmin";
            Text = "FrmAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlunos;
        private Button btnLivros;
        private Button btnEmprestimos;
        private DataGridView dgvDados;
    }
}