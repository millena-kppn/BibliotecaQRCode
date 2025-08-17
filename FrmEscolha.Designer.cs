namespace BibliotecaQRCode
{
    partial class FrmEscolha
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
            btnAdmin = new Button();
            btnAluno = new Button();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(280, 241);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(180, 82);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click_1;
            // 
            // btnAluno
            // 
            btnAluno.Location = new Point(280, 153);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(180, 82);
            btnAluno.TabIndex = 2;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = true;
            // 
            // FrmEscolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAluno);
            Controls.Add(btnAdmin);
            Name = "FrmEscolha";
            Text = "FrmEscolha";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdmin;
        private Button btnAluno;
    }
}