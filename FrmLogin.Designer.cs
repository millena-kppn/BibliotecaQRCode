//namespace BibliotecaQRCode
//{
//    partial class FrmLogin
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
//            txtMatricula = new TextBox();
//            btnEntrar = new Button();
//            labelMatricula = new Label();
//            SuspendLayout();
//            // 
//            // txtMatricula
//            // 
//            txtMatricula.Location = new Point(186, 89);
//            txtMatricula.Margin = new Padding(2);
//            txtMatricula.Name = "txtMatricula";
//            txtMatricula.Size = new Size(103, 23);
//            txtMatricula.TabIndex = 0;
//            // 
//            // btnEntrar
//            // 
//            btnEntrar.Location = new Point(193, 131);
//            btnEntrar.Margin = new Padding(2);
//            btnEntrar.Name = "btnEntrar";
//            btnEntrar.Size = new Size(76, 22);
//            btnEntrar.TabIndex = 1;
//            btnEntrar.Text = "Entrar";
//            btnEntrar.UseVisualStyleBackColor = true;
//            btnEntrar.Click += btnEntrar_Click_1;
//            // 
//            // labelMatricula
//            // 
//            labelMatricula.AutoSize = true;
//            labelMatricula.Location = new Point(202, 63);
//            labelMatricula.Margin = new Padding(2, 0, 2, 0);
//            labelMatricula.Name = "labelMatricula";
//            labelMatricula.Size = new Size(57, 15);
//            labelMatricula.TabIndex = 2;
//            labelMatricula.Text = "Matrícula";
//            // 
//            // FrmLogin
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.LightSteelBlue;
//            ClientSize = new Size(509, 270);
//            Controls.Add(labelMatricula);
//            Controls.Add(btnEntrar);
//            Controls.Add(txtMatricula);
//            Margin = new Padding(2);
//            Name = "FrmLogin";
//            Text = "FrmLogin";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private TextBox txtMatricula;
//        private Button btnEntrar;
//        private Label labelMatricula;
//    }
//}
//aqui
namespace BibliotecaQRCode
{
    partial class FrmLogin
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEntrar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ----------------------------
            // tableMain
            // ----------------------------
            this.tableMain.ColumnCount = 1;
            this.tableMain.RowCount = 3;
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableMain.Padding = new System.Windows.Forms.Padding(12);

            // ----------------------------
            // panelContent
            // ----------------------------
            this.panelContent.AutoSize = true;
            this.panelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.MinimumSize = new System.Drawing.Size(360, 160);
            this.panelContent.Padding = new System.Windows.Forms.Padding(12);

            // ----------------------------
            // lblTitulo
            // ----------------------------
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lblTitulo.Text = "Login Biblioteca";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 18);

            // ----------------------------
            // lblMatricula
            // ----------------------------
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMatricula.Text = "Matrícula:";
            this.lblMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);

            // ----------------------------
            // txtMatricula
            // ----------------------------
            this.txtMatricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.Size = new System.Drawing.Size(260, 27);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // ----------------------------
            // flowButtons
            // ----------------------------
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowButtons.WrapContents = false;
            this.flowButtons.AutoSize = true;
            this.flowButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowButtons.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);

            // ----------------------------
            // btnEntrar
            // ----------------------------
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.Size = new System.Drawing.Size(140, 42);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click_1);

            this.flowButtons.Controls.Add(this.btnEntrar);

            // ----------------------------
            // TableLayoutPanel interno para centralizar conteúdo
            // ----------------------------
            TableLayoutPanel innerLayout = new TableLayoutPanel();
            innerLayout.Dock = DockStyle.Fill;
            innerLayout.AutoSize = true;
            innerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            innerLayout.ColumnCount = 1;
            innerLayout.RowCount = 4;
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Título
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Matrícula label
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // TextBox
            innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Botões
            innerLayout.Padding = new Padding(12);
            innerLayout.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            innerLayout.Controls.Add(lblTitulo, 0, 0);
            innerLayout.Controls.Add(lblMatricula, 0, 1);
            innerLayout.Controls.Add(txtMatricula, 0, 2);
            innerLayout.Controls.Add(flowButtons, 0, 3);

            this.panelContent.Controls.Add(innerLayout);

            // ----------------------------
            // Adiciona panelContent à tableMain
            // ----------------------------
            this.tableMain.Controls.Add(this.panelContent, 0, 1);

            // ----------------------------
            // FrmLogin (form)
            // ----------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 420);
            this.Controls.Add(this.tableMain);
            this.MinimumSize = new System.Drawing.Size(520, 340);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnEntrar;
    }
}
