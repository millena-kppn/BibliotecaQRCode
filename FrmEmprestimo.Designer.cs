//aqui
//namespace BibliotecaQRCode
//{
//    partial class FrmEmprestimo
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
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

//        private void InitializeComponent()
//        {
//            tableMain = new TableLayoutPanel();
//            panelContent = new Panel();
//            innerLayout = new TableLayoutPanel();
//            lblAluno = new Label();
//            txtCodigoQR = new TextBox();
//            btnOk = new Button();
//            lblDescricao = new Label();
//            flowButtons = new FlowLayoutPanel();
//            btnDevolver = new Button();
//            tableMain.SuspendLayout();
//            panelContent.SuspendLayout();
//            innerLayout.SuspendLayout();
//            flowButtons.SuspendLayout();
//            SuspendLayout();
//            // 
//            // tableMain
//            // 
//            tableMain.BackColor = Color.LightSteelBlue;
//            tableMain.ColumnCount = 1;
//            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
//            tableMain.Controls.Add(panelContent, 0, 1);
//            tableMain.Dock = DockStyle.Fill;
//            tableMain.Location = new Point(0, 0);
//            tableMain.Name = "tableMain";
//            tableMain.Padding = new Padding(12);
//            tableMain.RowCount = 3;
//            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
//            tableMain.RowStyles.Add(new RowStyle());
//            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
//            tableMain.Size = new Size(600, 350);
//            tableMain.TabIndex = 0;
//            // 
//            // panelContent
//            // 
//            panelContent.AutoSize = true;
//            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
//            panelContent.Controls.Add(innerLayout);
//            panelContent.Dock = DockStyle.Fill;
//            panelContent.Location = new Point(15, 30);
//            panelContent.MinimumSize = new Size(360, 160);
//            panelContent.Name = "panelContent";
//            panelContent.Padding = new Padding(12);
//            panelContent.Size = new Size(570, 243);
//            panelContent.TabIndex = 0;
//            // 
//            // innerLayout
//            // 
//            innerLayout.AutoSize = true;
//            innerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
//            innerLayout.ColumnCount = 1;
//            innerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
//            innerLayout.Controls.Add(lblAluno, 0, 0);
//            innerLayout.Controls.Add(txtCodigoQR, 0, 1);
//            innerLayout.Controls.Add(btnOk, 0, 2);
//            innerLayout.Controls.Add(lblDescricao, 0, 3);
//            innerLayout.Controls.Add(flowButtons, 0, 4);
//            innerLayout.Dock = DockStyle.Fill;
//            innerLayout.Location = new Point(12, 12);
//            innerLayout.Name = "innerLayout";
//            innerLayout.Padding = new Padding(12);
//            innerLayout.RowCount = 5;
//            innerLayout.RowStyles.Add(new RowStyle());
//            innerLayout.RowStyles.Add(new RowStyle());
//            innerLayout.RowStyles.Add(new RowStyle());
//            innerLayout.RowStyles.Add(new RowStyle());
//            innerLayout.RowStyles.Add(new RowStyle());
//            innerLayout.Size = new Size(546, 219);
//            innerLayout.TabIndex = 0;
//            // 
//            // lblAluno
//            // 
//            lblAluno.AutoSize = true;
//            lblAluno.Dock = DockStyle.Fill;
//            lblAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
//            lblAluno.Location = new Point(12, 12);
//            lblAluno.Margin = new Padding(0, 0, 0, 10);
//            lblAluno.Name = "lblAluno";
//            lblAluno.Size = new Size(522, 21);
//            lblAluno.TabIndex = 0;
//            lblAluno.Text = "Aluno Logado";
//            lblAluno.TextAlign = ContentAlignment.MiddleCenter;
//            // 
//            // txtCodigoQR
//            // 
//            txtCodigoQR.Anchor = AnchorStyles.Top;
//            txtCodigoQR.Font = new Font("Segoe UI", 11F);
//            txtCodigoQR.Location = new Point(163, 43);
//            txtCodigoQR.Margin = new Padding(0, 0, 0, 10);
//            txtCodigoQR.Name = "txtCodigoQR";
//            txtCodigoQR.Size = new Size(220, 27);
//            txtCodigoQR.TabIndex = 1;
//            txtCodigoQR.TextAlign = HorizontalAlignment.Center;
//            txtCodigoQR.KeyDown += txtCodigoQR_KeyDown_1;
//            // 
//            // btnOk
//            // 
//            btnOk.Anchor = AnchorStyles.Top;
//            btnOk.BackColor = Color.SteelBlue;
//            btnOk.Cursor = Cursors.Hand;
//            btnOk.FlatAppearance.BorderSize = 0;
//            btnOk.FlatStyle = FlatStyle.Flat;
//            btnOk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnOk.ForeColor = Color.White;
//            btnOk.Location = new Point(203, 80);
//            btnOk.Margin = new Padding(0, 0, 0, 15);
//            btnOk.Name = "btnOk";
//            btnOk.Size = new Size(140, 35);
//            btnOk.TabIndex = 2;
//            btnOk.Text = "Ok";
//            btnOk.UseVisualStyleBackColor = false;
//            btnOk.Click += btnOk_Click;
//            // 
//            // lblDescricao
//            // 
//            lblDescricao.AutoSize = true;
//            lblDescricao.Dock = DockStyle.Fill;
//            lblDescricao.Font = new Font("Arial", 10F);
//            lblDescricao.Location = new Point(12, 130);
//            lblDescricao.Margin = new Padding(0, 0, 0, 10);
//            lblDescricao.MaximumSize = new Size(520, 0);
//            lblDescricao.Name = "lblDescricao";
//            lblDescricao.Size = new Size(520, 32);
//            lblDescricao.TabIndex = 3;
//            lblDescricao.Text = "Bipe seu livro e clique em \"Ok\" para gerar um empréstimo. Se deseja fazer uma devolução clique em \"Devolver Livros\".";
//            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
//            // 
//            // flowButtons
//            // 
//            flowButtons.Anchor = AnchorStyles.Top;
//            flowButtons.AutoSize = true;
//            flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
//            flowButtons.Controls.Add(btnDevolver);
//            flowButtons.Location = new Point(198, 172);
//            flowButtons.Margin = new Padding(0);
//            flowButtons.Name = "flowButtons";
//            flowButtons.Size = new Size(150, 35);
//            flowButtons.TabIndex = 4;
//            flowButtons.WrapContents = false;
//            // 
//            // btnDevolver
//            // 
//            btnDevolver.Anchor = AnchorStyles.None;
//            btnDevolver.BackColor = Color.SteelBlue;
//            btnDevolver.Cursor = Cursors.Hand;
//            btnDevolver.FlatAppearance.BorderSize = 0;
//            btnDevolver.FlatStyle = FlatStyle.Flat;
//            btnDevolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnDevolver.ForeColor = Color.White;
//            btnDevolver.Location = new Point(0, 0);
//            btnDevolver.Margin = new Padding(0);
//            btnDevolver.Name = "btnDevolver";
//            btnDevolver.Size = new Size(150, 35);
//            btnDevolver.TabIndex = 0;
//            btnDevolver.Text = "Devolver Livros";
//            btnDevolver.UseVisualStyleBackColor = false;
//            btnDevolver.Click += btnDevolver_Click_1;
//            // 
//            // FrmEmprestimo
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.WhiteSmoke;
//            ClientSize = new Size(600, 350);
//            Controls.Add(tableMain);
//            MinimumSize = new Size(520, 340);
//            Name = "FrmEmprestimo";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Empréstimo de Livros";
//            Load += FrmEmprestimo_Load_1;
//            tableMain.ResumeLayout(false);
//            tableMain.PerformLayout();
//            panelContent.ResumeLayout(false);
//            panelContent.PerformLayout();
//            innerLayout.ResumeLayout(false);
//            innerLayout.PerformLayout();
//            flowButtons.ResumeLayout(false);
//            ResumeLayout(false);
//        }

//        #endregion

//        private TableLayoutPanel tableMain;
//        private Panel panelContent;
//        private TableLayoutPanel innerLayout;
//        private Label lblAluno;
//        private TextBox txtCodigoQR;
//        private Button btnOk;
//        private Label lblDescricao;
//        private FlowLayoutPanel flowButtons;
//        private Button btnDevolver;
//    }
//}
//aqui
namespace BibliotecaQRCode
{
    partial class FrmEmprestimo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            tableMain = new TableLayoutPanel();
            panelContent = new Panel();
            innerLayout = new TableLayoutPanel();
            lblAluno = new Label();
            txtCodigoQR = new TextBox();
            btnOk = new Button();
            tableDescricao = new TableLayoutPanel();
            lblDescricao = new Label();
            flowButtons = new FlowLayoutPanel();
            btnDevolver = new Button();
            tableMain.SuspendLayout();
            panelContent.SuspendLayout();
            innerLayout.SuspendLayout();
            tableDescricao.SuspendLayout();
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
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableMain.RowStyles.Add(new RowStyle());
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableMain.Size = new Size(600, 350);
            tableMain.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.AutoSize = true;
            panelContent.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContent.Controls.Add(innerLayout);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(15, 30);
            panelContent.MinimumSize = new Size(360, 160);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(12);
            panelContent.Size = new Size(570, 243);
            panelContent.TabIndex = 0;
            // 
            // innerLayout
            // 
            innerLayout.AutoSize = true;
            innerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            innerLayout.ColumnCount = 1;
            innerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            innerLayout.Controls.Add(lblAluno, 0, 0);
            innerLayout.Controls.Add(txtCodigoQR, 0, 1);
            innerLayout.Controls.Add(btnOk, 0, 2);
            innerLayout.Controls.Add(tableDescricao, 0, 3);
            innerLayout.Controls.Add(flowButtons, 0, 4);
            innerLayout.Dock = DockStyle.Fill;
            innerLayout.Location = new Point(12, 12);
            innerLayout.Name = "innerLayout";
            innerLayout.Padding = new Padding(12);
            innerLayout.RowCount = 5;
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.Size = new Size(546, 219);
            innerLayout.TabIndex = 0;
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Dock = DockStyle.Fill;
            lblAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAluno.Location = new Point(12, 12);
            lblAluno.Margin = new Padding(0, 0, 0, 10);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(522, 21);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "Aluno Logado";
            lblAluno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Anchor = AnchorStyles.Top;
            txtCodigoQR.Font = new Font("Segoe UI", 11F);
            txtCodigoQR.Location = new Point(163, 43);
            txtCodigoQR.Margin = new Padding(0, 0, 0, 10);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(220, 27);
            txtCodigoQR.TabIndex = 1;
            txtCodigoQR.TextAlign = HorizontalAlignment.Center;
            txtCodigoQR.KeyDown += txtCodigoQR_KeyDown_1;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Top;
            btnOk.BackColor = Color.SteelBlue;
            btnOk.Cursor = Cursors.Hand;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(203, 80);
            btnOk.Margin = new Padding(0, 0, 0, 15);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(140, 35);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // tableDescricao
            // 
            tableDescricao.AutoSize = true;
            tableDescricao.ColumnCount = 3;
            tableDescricao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableDescricao.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableDescricao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableDescricao.Controls.Add(lblDescricao, 1, 0);
            tableDescricao.Dock = DockStyle.Fill;
            tableDescricao.Location = new Point(12, 130);
            tableDescricao.Margin = new Padding(0, 0, 0, 10);
            tableDescricao.Name = "tableDescricao";
            tableDescricao.RowCount = 1;
            tableDescricao.RowStyles.Add(new RowStyle());
            tableDescricao.Size = new Size(522, 32);
            tableDescricao.TabIndex = 5;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Arial", 10F);
            lblDescricao.MaximumSize = new Size(520, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Text = "Bipe seu livro e clique em \"Ok\" para gerar um empréstimo. Se deseja fazer uma devolução clique em \"Devolver Livros\".";
            lblDescricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Top;
            flowButtons.AutoSize = true;
            flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowButtons.Controls.Add(btnDevolver);
            flowButtons.Location = new Point(198, 172);
            flowButtons.Margin = new Padding(0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(150, 35);
            flowButtons.TabIndex = 4;
            flowButtons.WrapContents = false;
            // 
            // btnDevolver
            // 
            btnDevolver.Anchor = AnchorStyles.None;
            btnDevolver.BackColor = Color.SteelBlue;
            btnDevolver.Cursor = Cursors.Hand;
            btnDevolver.FlatAppearance.BorderSize = 0;
            btnDevolver.FlatStyle = FlatStyle.Flat;
            btnDevolver.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDevolver.ForeColor = Color.White;
            btnDevolver.Location = new Point(0, 0);
            btnDevolver.Margin = new Padding(0);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(150, 35);
            btnDevolver.TabIndex = 0;
            btnDevolver.Text = "Devolver Livros";
            btnDevolver.UseVisualStyleBackColor = false;
            btnDevolver.Click += btnDevolver_Click_1;
            // 
            // FrmEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(600, 350);
            Controls.Add(tableMain);
            MinimumSize = new Size(520, 340);
            Name = "FrmEmprestimo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empréstimo de Livros";
            Load += FrmEmprestimo_Load_1;
            tableMain.ResumeLayout(false);
            tableMain.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            innerLayout.ResumeLayout(false);
            innerLayout.PerformLayout();
            tableDescricao.ResumeLayout(false);
            tableDescricao.PerformLayout();
            flowButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableMain;
        private Panel panelContent;
        private TableLayoutPanel innerLayout;
        private Label lblAluno;
        private TextBox txtCodigoQR;
        private Button btnOk;
        private TableLayoutPanel tableDescricao;
        private Label lblDescricao;
        private FlowLayoutPanel flowButtons;
        private Button btnDevolver;
    }
}
