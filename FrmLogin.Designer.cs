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
            tableMain = new TableLayoutPanel();
            panelContent = new Panel();
            innerLayout = new TableLayoutPanel();
            lblTitulo = new Label();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            flowButtons = new FlowLayoutPanel();
            btnEntrar = new Button();
            tableMain.SuspendLayout();
            panelContent.SuspendLayout();
            innerLayout.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableMain
            // 
            tableMain.BackColor = Color.LightSteelBlue;
            tableMain.ColumnCount = 1;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableMain.Controls.Add(panelContent, 0, 1);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 0);
            tableMain.Name = "tableMain";
            tableMain.Padding = new Padding(12);
            tableMain.RowCount = 3;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableMain.RowStyles.Add(new RowStyle());
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 67F));
            tableMain.Size = new Size(700, 420);
            tableMain.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.AutoSize = true;
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.Controls.Add(innerLayout);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(15, 67);
            panelContent.MinimumSize = new Size(360, 160);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(12);
            panelContent.Size = new Size(670, 231);
            panelContent.TabIndex = 0;
            // 
            // innerLayout
            // 
            innerLayout.AutoSize = true;
            innerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            innerLayout.ColumnCount = 1;
            innerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            innerLayout.Controls.Add(lblTitulo, 0, 0);
            innerLayout.Controls.Add(lblMatricula, 0, 1);
            innerLayout.Controls.Add(txtMatricula, 0, 2);
            innerLayout.Controls.Add(flowButtons, 0, 3);
            innerLayout.Dock = DockStyle.Fill;
            innerLayout.Location = new Point(12, 12);
            innerLayout.Name = "innerLayout";
            innerLayout.Padding = new Padding(12);
            innerLayout.RowCount = 4;
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.Size = new Size(646, 207);
            innerLayout.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Margin = new Padding(0, 0, 0, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(622, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Login Biblioteca";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Dock = DockStyle.Fill;
            lblMatricula.Font = new Font("Segoe UI", 12F);
            lblMatricula.Location = new Point(12, 73);
            lblMatricula.Margin = new Padding(0, 6, 0, 6);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(622, 21);
            lblMatricula.TabIndex = 1;
            lblMatricula.Text = "Digite sua matrícula na caixa de texto:";
            lblMatricula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Top;
            txtMatricula.Font = new Font("Segoe UI", 11F);
            txtMatricula.Location = new Point(193, 100);
            txtMatricula.Margin = new Padding(0, 0, 0, 18);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(260, 27);
            txtMatricula.TabIndex = 2;
            txtMatricula.TextAlign = HorizontalAlignment.Center;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Top;
            flowButtons.AutoSize = true;
            flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowButtons.Controls.Add(btnEntrar);
            flowButtons.Location = new Point(253, 153);
            flowButtons.Margin = new Padding(0, 8, 0, 0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(140, 42);
            flowButtons.TabIndex = 3;
            flowButtons.WrapContents = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = Color.FromArgb(70, 130, 180);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(0, 0);
            btnEntrar.Margin = new Padding(0);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(140, 42);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 420);
            Controls.Add(tableMain);
            MinimumSize = new Size(520, 340);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnEntrar;
        private TableLayoutPanel innerLayout;
    }
}
