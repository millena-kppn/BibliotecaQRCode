//namespace BibliotecaQRCode
//{
//    partial class FrmLivroEditar
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
//            txtTitulo = new TextBox();
//            txtAutor = new TextBox();
//            txtCodigoQR = new TextBox();
//            btnOK = new Button();
//            btnCancelar = new Button();
//            lblTitulo = new Label();
//            lblAutor = new Label();
//            lblCodigoQR = new Label();
//            SuspendLayout();
//            // 
//            // txtTitulo
//            // 
//            txtTitulo.Location = new Point(253, 90);
//            txtTitulo.Name = "txtTitulo";
//            txtTitulo.Size = new Size(100, 23);
//            txtTitulo.TabIndex = 0;
//            // 
//            // txtAutor
//            // 
//            txtAutor.Location = new Point(253, 139);
//            txtAutor.Name = "txtAutor";
//            txtAutor.Size = new Size(100, 23);
//            txtAutor.TabIndex = 1;
//            // 
//            // txtCodigoQR
//            // 
//            txtCodigoQR.Location = new Point(253, 183);
//            txtCodigoQR.Name = "txtCodigoQR";
//            txtCodigoQR.Size = new Size(100, 23);
//            txtCodigoQR.TabIndex = 2;
//            // 
//            // btnOK
//            // 
//            btnOK.Location = new Point(458, 265);
//            btnOK.Name = "btnOK";
//            btnOK.Size = new Size(75, 23);
//            btnOK.TabIndex = 3;
//            btnOK.Text = "OK";
//            btnOK.UseVisualStyleBackColor = true;
//            btnOK.Click += btnOK_Click_1;
//            // 
//            // btnCancelar
//            // 
//            btnCancelar.Location = new Point(563, 265);
//            btnCancelar.Name = "btnCancelar";
//            btnCancelar.Size = new Size(75, 23);
//            btnCancelar.TabIndex = 4;
//            btnCancelar.Text = "Cancelar";
//            btnCancelar.UseVisualStyleBackColor = true;
//            btnCancelar.Click += btnCancelar_Click_1;
//            // 
//            // lblTitulo
//            // 
//            lblTitulo.AutoSize = true;
//            lblTitulo.Location = new Point(253, 72);
//            lblTitulo.Name = "lblTitulo";
//            lblTitulo.Size = new Size(38, 15);
//            lblTitulo.TabIndex = 5;
//            lblTitulo.Text = "Titulo";
//            // 
//            // lblAutor
//            // 
//            lblAutor.AutoSize = true;
//            lblAutor.Location = new Point(253, 121);
//            lblAutor.Name = "lblAutor";
//            lblAutor.Size = new Size(37, 15);
//            lblAutor.TabIndex = 6;
//            lblAutor.Text = "Autor";
//            // 
//            // lblCodigoQR
//            // 
//            lblCodigoQR.AutoSize = true;
//            lblCodigoQR.Location = new Point(253, 165);
//            lblCodigoQR.Name = "lblCodigoQR";
//            lblCodigoQR.Size = new Size(62, 15);
//            lblCodigoQR.TabIndex = 7;
//            lblCodigoQR.Text = "CodigoQR";
//            // 
//            // FrmLivroEditar
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.LightSteelBlue;
//            ClientSize = new Size(800, 450);
//            Controls.Add(lblCodigoQR);
//            Controls.Add(lblAutor);
//            Controls.Add(lblTitulo);
//            Controls.Add(btnCancelar);
//            Controls.Add(btnOK);
//            Controls.Add(txtCodigoQR);
//            Controls.Add(txtAutor);
//            Controls.Add(txtTitulo);
//            Name = "FrmLivroEditar";
//            Text = "FrmLivroEditar";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private TextBox txtTitulo;
//        private TextBox txtAutor;
//        private TextBox txtCodigoQR;
//        private Button btnOK;
//        private Button btnCancelar;
//        private Label lblTitulo;
//        private Label lblAutor;
//        private Label lblCodigoQR;
//    }
//}
//aqui
namespace BibliotecaQRCode
{
    partial class FrmLivroEditar
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
            tableMain = new TableLayoutPanel();
            panelContent = new Panel();
            innerLayout = new TableLayoutPanel();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblCodigoQR = new Label();
            txtCodigoQR = new TextBox();
            flowButtons = new FlowLayoutPanel();
            btnOK = new Button();
            btnCancelar = new Button();
            tableMain.SuspendLayout();
            panelContent.SuspendLayout();
            innerLayout.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableMain
            // 
            tableMain.ColumnCount = 1;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableMain.Controls.Add(panelContent, 0, 1);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 0);
            tableMain.Name = "tableMain";
            tableMain.Padding = new Padding(12);
            tableMain.RowCount = 3;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableMain.RowStyles.Add(new RowStyle());
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableMain.Size = new Size(800, 450);
            tableMain.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.AutoSize = true;
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.Controls.Add(innerLayout);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(15, 37);
            panelContent.MinimumSize = new Size(400, 250);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(12);
            panelContent.Size = new Size(770, 306);
            panelContent.TabIndex = 0;
            // 
            // innerLayout
            // 
            innerLayout.AutoSize = true;
            innerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            innerLayout.ColumnCount = 1;
            innerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            innerLayout.Controls.Add(lblTitulo, 0, 0);
            innerLayout.Controls.Add(txtTitulo, 0, 1);
            innerLayout.Controls.Add(lblAutor, 0, 2);
            innerLayout.Controls.Add(txtAutor, 0, 3);
            innerLayout.Controls.Add(lblCodigoQR, 0, 4);
            innerLayout.Controls.Add(txtCodigoQR, 0, 5);
            innerLayout.Controls.Add(flowButtons, 0, 6);
            innerLayout.Dock = DockStyle.Fill;
            innerLayout.Location = new Point(12, 12);
            innerLayout.Name = "innerLayout";
            innerLayout.Padding = new Padding(12);
            innerLayout.RowCount = 7;
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.Size = new Size(746, 282);
            innerLayout.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Margin = new Padding(0, 6, 0, 2);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(722, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título do Livro:";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.Font = new Font("Segoe UI", 11F);
            txtTitulo.Location = new Point(12, 41);
            txtTitulo.Margin = new Padding(0, 0, 0, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(722, 27);
            txtTitulo.TabIndex = 1;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Dock = DockStyle.Fill;
            lblAutor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAutor.Location = new Point(12, 86);
            lblAutor.Margin = new Padding(0, 6, 0, 2);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(722, 21);
            lblAutor.TabIndex = 2;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAutor.Font = new Font("Segoe UI", 11F);
            txtAutor.Location = new Point(12, 109);
            txtAutor.Margin = new Padding(0, 0, 0, 12);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(722, 27);
            txtAutor.TabIndex = 3;
            // 
            // lblCodigoQR
            // 
            lblCodigoQR.AutoSize = true;
            lblCodigoQR.Dock = DockStyle.Fill;
            lblCodigoQR.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCodigoQR.Location = new Point(12, 154);
            lblCodigoQR.Margin = new Padding(0, 6, 0, 2);
            lblCodigoQR.Name = "lblCodigoQR";
            lblCodigoQR.Size = new Size(722, 21);
            lblCodigoQR.TabIndex = 4;
            lblCodigoQR.Text = "Código QR:";
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigoQR.Font = new Font("Segoe UI", 11F);
            txtCodigoQR.Location = new Point(12, 177);
            txtCodigoQR.Margin = new Padding(0, 0, 0, 12);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(722, 27);
            txtCodigoQR.TabIndex = 5;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Top;
            flowButtons.AutoSize = true;
            flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowButtons.Controls.Add(btnOK);
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Location = new Point(267, 228);
            flowButtons.Margin = new Padding(0, 12, 0, 0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(212, 42);
            flowButtons.TabIndex = 6;
            flowButtons.WrapContents = false;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.FromArgb(70, 130, 180);
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(3, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 36);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(109, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FrmLivroEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tableMain);
            MinimumSize = new Size(600, 400);
            Name = "FrmLivroEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Livro";
            tableMain.ResumeLayout(false);
            tableMain.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            innerLayout.ResumeLayout(false);
            innerLayout.PerformLayout();
            flowButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableMain;
        private Panel panelContent;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblCodigoQR;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtCodigoQR;
        private FlowLayoutPanel flowButtons;
        private Button btnOK;
        private Button btnCancelar;
        private TableLayoutPanel innerLayout;
    }
}
