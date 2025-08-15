namespace BibliotecaQRCode
{
    partial class FrmEmprestimo
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
            lblAluno = new Label();
            txtCodigoQR = new TextBox();
            btnDevolver = new Button();
            SuspendLayout();
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Location = new Point(275, 100);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(130, 25);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "Aluno Logado";
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(256, 181);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(160, 33);
            txtCodigoQR.TabIndex = 1;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(239, 268);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(190, 37);
            btnDevolver.TabIndex = 2;
            btnDevolver.Text = "Devolver livros";
            btnDevolver.UseVisualStyleBackColor = true;
            // 
            // FrmEmprestimo
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDevolver);
            Controls.Add(txtCodigoQR);
            Controls.Add(lblAluno);
            Name = "FrmEmprestimo";
            Text = "FrmEmprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAluno;
        private TextBox txtCodigoQR;
        private Button btnDevolver;
    }
}