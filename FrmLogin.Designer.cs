namespace BibliotecaQRCode
{
    partial class FrmLogin
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
            txtMatricula = new TextBox();
            btnEntrar = new Button();
            labelMatricula = new Label();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(293, 148);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(160, 33);
            txtMatricula.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(333, 222);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(120, 37);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(295, 106);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(92, 25);
            labelMatricula.TabIndex = 2;
            labelMatricula.Text = "Matrícula";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMatricula);
            Controls.Add(btnEntrar);
            Controls.Add(txtMatricula);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private Button btnEntrar;
        private Label labelMatricula;
    }
}