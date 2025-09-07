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
            lblDescricao = new Label();
            SuspendLayout();
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Location = new Point(174, 68);
            lblAluno.Margin = new Padding(2, 0, 2, 0);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(82, 15);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "Aluno Logado";
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(163, 109);
            txtCodigoQR.Margin = new Padding(2);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(103, 23);
            txtCodigoQR.TabIndex = 1;
            txtCodigoQR.KeyDown += txtCodigoQR_KeyDown_1;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(145, 193);
            btnDevolver.Margin = new Padding(2);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(121, 22);
            btnDevolver.TabIndex = 2;
            btnDevolver.Text = "Devolver livros";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click_1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(23, 147);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(464, 15);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Bip seu livro e click em \"Ok\", se deseja fazer uma devolução click em \"Devolver Livros\".";
            // 
            // FrmEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(509, 270);
            Controls.Add(lblDescricao);
            Controls.Add(btnDevolver);
            Controls.Add(txtCodigoQR);
            Controls.Add(lblAluno);
            Margin = new Padding(2);
            Name = "FrmEmprestimo";
            Text = "FrmEmprestimo";
            Load += FrmEmprestimo_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAluno;
        private TextBox txtCodigoQR;
        private Button btnDevolver;
        private Label lblDescricao;
    }
}