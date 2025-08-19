namespace BibliotecaQRCode
{
    partial class FrmLivroEditar
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
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtCodigoQR = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblCodigoQR = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(253, 90);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(253, 139);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 1;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(253, 183);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(100, 23);
            txtCodigoQR.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(458, 265);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(563, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(253, 72);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Titulo";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(253, 121);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "Autor";
            // 
            // lblCodigoQR
            // 
            lblCodigoQR.AutoSize = true;
            lblCodigoQR.Location = new Point(253, 165);
            lblCodigoQR.Name = "lblCodigoQR";
            lblCodigoQR.Size = new Size(62, 15);
            lblCodigoQR.TabIndex = 7;
            lblCodigoQR.Text = "CodigoQR";
            // 
            // FrmLivroEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCodigoQR);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtCodigoQR);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "FrmLivroEditar";
            Text = "FrmLivroEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtCodigoQR;
        private Button btnOK;
        private Button btnCancelar;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblCodigoQR;
    }
}