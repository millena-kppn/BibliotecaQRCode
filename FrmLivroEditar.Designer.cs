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
            this.components = new System.ComponentModel.Container();

            // Controles
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCodigoQR = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoQR = new System.Windows.Forms.TextBox();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ----------------------------
            // tableMain
            // ----------------------------
            this.tableMain.ColumnCount = 1;
            this.tableMain.RowCount = 3;
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F)); // Topo
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));      // Conteúdo central
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F)); // Rodapé
            this.tableMain.Padding = new Padding(12);

            // ----------------------------
            // panelContent
            // ----------------------------
            this.panelContent.AutoSize = true;
            this.panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.MinimumSize = new System.Drawing.Size(400, 250);
            this.panelContent.Padding = new Padding(12);

            // ----------------------------
            // Labels
            // ----------------------------
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Text = "Título do Livro:";
            this.lblTitulo.Dock = DockStyle.Fill;
            this.lblTitulo.Margin = new Padding(0, 6, 0, 2);

            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblAutor.Text = "Autor:";
            this.lblAutor.Dock = DockStyle.Fill;
            this.lblAutor.Margin = new Padding(0, 6, 0, 2);

            this.lblCodigoQR.AutoSize = true;
            this.lblCodigoQR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblCodigoQR.Text = "Código QR:";
            this.lblCodigoQR.Dock = DockStyle.Fill;
            this.lblCodigoQR.Margin = new Padding(0, 6, 0, 2);

            // ----------------------------
            // TextBoxes
            // ----------------------------
            this.txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtTitulo.Margin = new Padding(0, 0, 0, 12);

            this.txtAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtAutor.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtAutor.Margin = new Padding(0, 0, 0, 12);

            this.txtCodigoQR.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.txtCodigoQR.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtCodigoQR.Margin = new Padding(0, 0, 0, 12);

            // ----------------------------
            // flowButtons
            // ----------------------------
            this.flowButtons.FlowDirection = FlowDirection.LeftToRight;
            this.flowButtons.WrapContents = false;
            this.flowButtons.AutoSize = true;
            this.flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.flowButtons.Anchor = AnchorStyles.Top;
            this.flowButtons.Margin = new Padding(0, 12, 0, 0);

            this.btnOK.Text = "OK";
            this.btnOK.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnOK.BackColor = Color.FromArgb(70, 130, 180);
            this.btnOK.ForeColor = Color.White;
            this.btnOK.FlatStyle = FlatStyle.Flat;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Size = new Size(100, 36);
            this.btnOK.Click += new EventHandler(this.btnOK_Click_1);

            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnCancelar.BackColor = Color.Gray;
            this.btnCancelar.ForeColor = Color.White;
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Size = new Size(100, 36);
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click_1);

            this.flowButtons.Controls.Add(this.btnOK);
            this.flowButtons.Controls.Add(this.btnCancelar);

            // ----------------------------
            // TableLayoutPanel interno para centralizar conteúdo
            // ----------------------------
            TableLayoutPanel innerLayout = new TableLayoutPanel();
            innerLayout.Dock = DockStyle.Fill;
            innerLayout.AutoSize = true;
            innerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            innerLayout.ColumnCount = 1;
            innerLayout.RowCount = 7;
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // lblTitulo
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // txtTitulo
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // lblAutor
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // txtAutor
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // lblCodigoQR
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // txtCodigoQR
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // flowButtons
            innerLayout.Padding = new Padding(12);
            innerLayout.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            innerLayout.Controls.Add(lblTitulo, 0, 0);
            innerLayout.Controls.Add(txtTitulo, 0, 1);
            innerLayout.Controls.Add(lblAutor, 0, 2);
            innerLayout.Controls.Add(txtAutor, 0, 3);
            innerLayout.Controls.Add(lblCodigoQR, 0, 4);
            innerLayout.Controls.Add(txtCodigoQR, 0, 5);
            innerLayout.Controls.Add(flowButtons, 0, 6);

            this.panelContent.Controls.Add(innerLayout);

            // ----------------------------
            // Adiciona panelContent à tableMain
            // ----------------------------
            this.tableMain.Controls.Add(this.panelContent, 0, 1);

            // ----------------------------
            // FrmLivroEditar (form)
            // ----------------------------
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightSteelBlue;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.tableMain);
            this.MinimumSize = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Editar Livro";
            this.FormBorderStyle = FormBorderStyle.Sizable;

            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
