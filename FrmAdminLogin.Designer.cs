//namespace BibliotecaQRCode
//{
//    partial class FrmAdminLogin
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            txtSenha = new TextBox();
//            btnEntrar = new Button();
//            btnCancelar = new Button();
//            txtLogin = new TextBox();
//            btnEsqueciSenha = new Button();
//            SuspendLayout();
//            // 
//            // txtSenha
//            // 
//            txtSenha.Location = new Point(490, 292);
//            txtSenha.Margin = new Padding(5);
//            txtSenha.Name = "txtSenha";
//            txtSenha.Size = new Size(155, 33);
//            txtSenha.TabIndex = 0;
//            // 
//            // btnEntrar
//            // 
//            btnEntrar.Location = new Point(393, 375);
//            btnEntrar.Margin = new Padding(5);
//            btnEntrar.Name = "btnEntrar";
//            btnEntrar.Size = new Size(118, 38);
//            btnEntrar.TabIndex = 1;
//            btnEntrar.Text = "Entrar";
//            btnEntrar.UseVisualStyleBackColor = true;
//            btnEntrar.Click += btnEntrar_Click;
//            // 
//            // btnCancelar
//            // 
//            btnCancelar.Location = new Point(530, 375);
//            btnCancelar.Margin = new Padding(5);
//            btnCancelar.Name = "btnCancelar";
//            btnCancelar.Size = new Size(118, 38);
//            btnCancelar.TabIndex = 2;
//            btnCancelar.Text = "Cancelar";
//            btnCancelar.UseVisualStyleBackColor = true;
//            btnCancelar.Click += btnCancelar_Click;
//            // 
//            // txtLogin
//            // 
//            txtLogin.Location = new Point(485, 221);
//            txtLogin.Name = "txtLogin";
//            txtLogin.Size = new Size(160, 33);
//            txtLogin.TabIndex = 3;
//            // 
//            // btnEsqueciSenha
//            // 
//            btnEsqueciSenha.Location = new Point(422, 451);
//            btnEsqueciSenha.Name = "btnEsqueciSenha";
//            btnEsqueciSenha.Size = new Size(210, 37);
//            btnEsqueciSenha.TabIndex = 4;
//            btnEsqueciSenha.Text = "Esqueci minha senha";
//            btnEsqueciSenha.UseVisualStyleBackColor = true;
//            btnEsqueciSenha.Click += btnEsqueciSenha_Click;
//            // 
//            // FrmAdminLogin
//            // 
//            AutoScaleDimensions = new SizeF(11F, 25F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.LightSteelBlue;
//            ClientSize = new Size(1257, 750);
//            Controls.Add(btnEsqueciSenha);
//            Controls.Add(txtLogin);
//            Controls.Add(btnCancelar);
//            Controls.Add(btnEntrar);
//            Controls.Add(txtSenha);
//            Margin = new Padding(5);
//            Name = "FrmAdminLogin";
//            Text = "FrmAdmin";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private TextBox txtSenha;
//        private Button btnEntrar;
//        private Button btnCancelar;
//        private TextBox txtLogin;
//        private Button btnEsqueciSenha;
//    }
//}
//aqui
namespace BibliotecaQRCode
{
    partial class FrmAdminLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelLogin = new Panel();
            this.lblLogin = new Label();
            this.lblSenha = new Label();
            this.txtLogin = new TextBox();
            this.txtSenha = new TextBox();
            this.btnEntrar = new Button();
            this.btnCancelar = new Button();
            this.btnEsqueciSenha = new Button();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = AnchorStyles.None;
            this.panelLogin.Size = new Size(400, 300);
            this.panelLogin.Location = new Point((1257 - 400) / 2, (750 - 300) / 2);
            this.panelLogin.BackColor = Color.WhiteSmoke;
            this.panelLogin.Padding = new Padding(20);
            this.panelLogin.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblLogin
            // 
            this.lblLogin.Text = "Login:";
            this.lblLogin.Location = new Point(50, 40);
            this.lblLogin.AutoSize = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new Point(150, 40);
            this.txtLogin.Size = new Size(200, 30);
            // 
            // lblSenha
            // 
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Location = new Point(50, 100);
            this.lblSenha.AutoSize = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new Point(150, 100);
            this.txtSenha.Size = new Size(200, 30);
            this.txtSenha.PasswordChar = '*';
            // 
            // btnEntrar
            // 
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Location = new Point(50, 170);
            this.btnEntrar.Size = new Size(100, 40);
            this.btnEntrar.BackColor = Color.SeaGreen;
            this.btnEntrar.ForeColor = Color.White;
            this.btnEntrar.Click += new EventHandler(this.btnEntrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Location = new Point(170, 170);
            this.btnCancelar.Size = new Size(100, 40);
            this.btnCancelar.BackColor = Color.Firebrick;
            this.btnCancelar.ForeColor = Color.White;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            // 
            // btnEsqueciSenha
            // 
            this.btnEsqueciSenha.Text = "Esqueci minha senha";
            this.btnEsqueciSenha.Location = new Point(50, 230);
            this.btnEsqueciSenha.Size = new Size(300, 35);
            this.btnEsqueciSenha.BackColor = Color.SteelBlue;
            this.btnEsqueciSenha.ForeColor = Color.White;
            this.btnEsqueciSenha.Click += new EventHandler(this.btnEsqueciSenha_Click);
            // 
            // FrmAdminLogin
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightSteelBlue;
            this.ClientSize = new Size(1257, 750);
            this.Controls.Add(this.panelLogin);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.txtLogin);
            this.panelLogin.Controls.Add(this.lblSenha);
            this.panelLogin.Controls.Add(this.txtSenha);
            this.panelLogin.Controls.Add(this.btnEntrar);
            this.panelLogin.Controls.Add(this.btnCancelar);
            this.panelLogin.Controls.Add(this.btnEsqueciSenha);
            this.Name = "FrmAdminLogin";
            this.Text = "Login Administrativo";
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label lblLogin;
        private Label lblSenha;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Button btnCancelar;
        private Button btnEsqueciSenha;
    }
}
