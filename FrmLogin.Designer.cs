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
            txtMatricula.Location = new Point(186, 89);
            txtMatricula.Margin = new Padding(2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(103, 23);
            txtMatricula.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(193, 131);
            btnEntrar.Margin = new Padding(2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(76, 22);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(202, 63);
            labelMatricula.Margin = new Padding(2, 0, 2, 0);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(57, 15);
            labelMatricula.TabIndex = 2;
            labelMatricula.Text = "Matrícula";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(509, 270);
            Controls.Add(labelMatricula);
            Controls.Add(btnEntrar);
            Controls.Add(txtMatricula);
            Margin = new Padding(2);
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