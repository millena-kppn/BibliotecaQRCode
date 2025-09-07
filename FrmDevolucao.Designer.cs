//namespace BibliotecaQRCode
//{
//    partial class FrmDevolucao
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
//            txtCodigoQR = new TextBox();
//            btnDevolver = new Button();
//            lblDescricao = new Label();
//            SuspendLayout();
//            // 
//            // txtCodigoQR
//            // 
//            txtCodigoQR.Location = new Point(174, 77);
//            txtCodigoQR.Margin = new Padding(2);
//            txtCodigoQR.Name = "txtCodigoQR";
//            txtCodigoQR.Size = new Size(103, 23);
//            txtCodigoQR.TabIndex = 0;
//            txtCodigoQR.KeyDown += txtCodigoQR_KeyDown_1;
//            // 
//            // btnDevolver
//            // 
//            btnDevolver.Location = new Point(187, 126);
//            btnDevolver.Margin = new Padding(2);
//            btnDevolver.Name = "btnDevolver";
//            btnDevolver.Size = new Size(76, 22);
//            btnDevolver.TabIndex = 1;
//            btnDevolver.Text = "Devolver";
//            btnDevolver.UseVisualStyleBackColor = true;
//            btnDevolver.Click += btnDevolver_Click;
//            // 
//            // lblDescricao
//            // 
//            lblDescricao.AutoSize = true;
//            lblDescricao.Location = new Point(123, 49);
//            lblDescricao.Name = "lblDescricao";
//            lblDescricao.Size = new Size(209, 15);
//            lblDescricao.TabIndex = 2;
//            lblDescricao.Text = "Após bipar seu livro click em devolver.";
//            // 
//            // FrmDevolucao
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.LightSteelBlue;
//            ClientSize = new Size(509, 270);
//            Controls.Add(lblDescricao);
//            Controls.Add(btnDevolver);
//            Controls.Add(txtCodigoQR);
//            Margin = new Padding(2);
//            Name = "FrmDevolucao";
//            Text = "FrmDevolucao";
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private TextBox txtCodigoQR;
//        private Button btnDevolver;
//        private Label lblDescricao;
//    }
//}
//aqui
namespace BibliotecaQRCode
{
    partial class FrmDevolucao
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
            lblDescricao = new Label();
            txtCodigoQR = new TextBox();
            flowButtons = new FlowLayoutPanel();
            btnDevolver = new Button();
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
            innerLayout.Controls.Add(lblDescricao, 0, 1);
            innerLayout.Controls.Add(txtCodigoQR, 0, 2);
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
            lblTitulo.Text = "Devolução de Livros";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Dock = DockStyle.Fill;
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.Location = new Point(12, 73);
            lblDescricao.Margin = new Padding(0, 6, 0, 6);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(622, 21);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Após bipar o livro, clique em Devolver.";
            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Anchor = AnchorStyles.Top;
            txtCodigoQR.Font = new Font("Segoe UI", 11F);
            txtCodigoQR.Location = new Point(193, 100);
            txtCodigoQR.Margin = new Padding(0, 0, 0, 18);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(260, 27);
            txtCodigoQR.TabIndex = 2;
            txtCodigoQR.TextAlign = HorizontalAlignment.Center;
            txtCodigoQR.KeyDown += txtCodigoQR_KeyDown_1;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Top;
            flowButtons.AutoSize = true;
            flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowButtons.Controls.Add(btnDevolver);
            flowButtons.Location = new Point(253, 153);
            flowButtons.Margin = new Padding(0, 8, 0, 0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(140, 42);
            flowButtons.TabIndex = 3;
            flowButtons.WrapContents = false;
            // 
            // btnDevolver
            // 
            btnDevolver.Anchor = AnchorStyles.None;
            btnDevolver.BackColor = Color.FromArgb(70, 130, 180);
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(0, 0);
            btnDevolver.Margin = new Padding(0);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(140, 42);
            btnDevolver.TabIndex = 0;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // FrmDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 420);
            Controls.Add(tableMain);
            MinimumSize = new Size(520, 340);
            Name = "FrmDevolucao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Devolução";
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
        private TableLayoutPanel innerLayout;
        private Label lblTitulo;
        private Label lblDescricao;
        private TextBox txtCodigoQR;
        private FlowLayoutPanel flowButtons;
        private Button btnDevolver;
    }
}
