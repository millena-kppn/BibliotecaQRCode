namespace BibliotecaQRCode
{
    partial class FrmAdminLogin
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
            txtSenha = new TextBox();
            btnEntrar = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            btnEsqueciSenha = new Button();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(490, 292);
            txtSenha.Margin = new Padding(5);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(155, 33);
            txtSenha.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(393, 375);
            btnEntrar.Margin = new Padding(5);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(118, 38);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(530, 375);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 38);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(485, 221);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(160, 33);
            txtUsuario.TabIndex = 3;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.Location = new Point(422, 451);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(210, 37);
            btnEsqueciSenha.TabIndex = 4;
            btnEsqueciSenha.Text = "Esqueci minha senha";
            btnEsqueciSenha.UseVisualStyleBackColor = true;
            btnEsqueciSenha.Click += btnEsqueciSenha_Click;
            // 
            // FrmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1257, 750);
            Controls.Add(btnEsqueciSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Margin = new Padding(5);
            Name = "FrmAdminLogin";
            Text = "FrmAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private Button btnEsqueciSenha;
    }
}