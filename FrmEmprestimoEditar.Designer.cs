//aqui
namespace BibliotecaQRCode
{
    partial class FrmEmprestimoEditar
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
            lblAluno = new Label();
            txtAluno = new TextBox();
            lblLivro = new Label();
            txtLivro = new TextBox();
            lblDataEmprestimo = new Label();
            dtpEmprestimo = new DateTimePicker();
            lblDataDevolucao = new Label();
            dtpDevolucao = new DateTimePicker();
            flowButtons = new FlowLayoutPanel();
            btnSalvar = new Button();
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
            panelContent.MinimumSize = new Size(400, 300);
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
            innerLayout.Controls.Add(lblAluno, 0, 0);
            innerLayout.Controls.Add(txtAluno, 0, 1);
            innerLayout.Controls.Add(lblLivro, 0, 2);
            innerLayout.Controls.Add(txtLivro, 0, 3);
            innerLayout.Controls.Add(lblDataEmprestimo, 0, 4);
            innerLayout.Controls.Add(dtpEmprestimo, 0, 5);
            innerLayout.Controls.Add(lblDataDevolucao, 0, 6);
            innerLayout.Controls.Add(dtpDevolucao, 0, 7);
            innerLayout.Controls.Add(flowButtons, 0, 8);
            innerLayout.Dock = DockStyle.Fill;
            innerLayout.Location = new Point(12, 12);
            innerLayout.Name = "innerLayout";
            innerLayout.Padding = new Padding(12);
            innerLayout.RowCount = 9;
            innerLayout.RowStyles.Add(new RowStyle());
            innerLayout.RowStyles.Add(new RowStyle());
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
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Dock = DockStyle.Fill;
            lblAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAluno.Location = new Point(12, 18);
            lblAluno.Margin = new Padding(0, 6, 0, 2);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(722, 21);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "Aluno:";
            // 
            // txtAluno
            // 
            txtAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAluno.Font = new Font("Segoe UI", 11F);
            txtAluno.Location = new Point(12, 41);
            txtAluno.Margin = new Padding(0, 0, 0, 12);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(722, 27);
            txtAluno.TabIndex = 1;
            // 
            // lblLivro
            // 
            lblLivro.AutoSize = true;
            lblLivro.Dock = DockStyle.Fill;
            lblLivro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLivro.Location = new Point(12, 86);
            lblLivro.Margin = new Padding(0, 6, 0, 2);
            lblLivro.Name = "lblLivro";
            lblLivro.Size = new Size(722, 21);
            lblLivro.TabIndex = 2;
            lblLivro.Text = "Livro:";
            // 
            // txtLivro
            // 
            txtLivro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLivro.Font = new Font("Segoe UI", 11F);
            txtLivro.Location = new Point(12, 109);
            txtLivro.Margin = new Padding(0, 0, 0, 12);
            txtLivro.Name = "txtLivro";
            txtLivro.Size = new Size(722, 27);
            txtLivro.TabIndex = 3;
            // 
            // lblDataEmprestimo
            // 
            lblDataEmprestimo.AutoSize = true;
            lblDataEmprestimo.Dock = DockStyle.Fill;
            lblDataEmprestimo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDataEmprestimo.Location = new Point(12, 154);
            lblDataEmprestimo.Margin = new Padding(0, 6, 0, 2);
            lblDataEmprestimo.Name = "lblDataEmprestimo";
            lblDataEmprestimo.Size = new Size(722, 21);
            lblDataEmprestimo.TabIndex = 4;
            lblDataEmprestimo.Text = "Data Empréstimo:";
            // 
            // dtpEmprestimo
            // 
            dtpEmprestimo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpEmprestimo.Font = new Font("Segoe UI", 11F);
            dtpEmprestimo.Location = new Point(12, 177);
            dtpEmprestimo.Margin = new Padding(0, 0, 0, 12);
            dtpEmprestimo.Name = "dtpEmprestimo";
            dtpEmprestimo.Size = new Size(722, 27);
            dtpEmprestimo.TabIndex = 5;
            // 
            // lblDataDevolucao
            // 
            lblDataDevolucao.AutoSize = true;
            lblDataDevolucao.Dock = DockStyle.Fill;
            lblDataDevolucao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDataDevolucao.Location = new Point(12, 216);
            lblDataDevolucao.Margin = new Padding(0, 6, 0, 2);
            lblDataDevolucao.Name = "lblDataDevolucao";
            lblDataDevolucao.Size = new Size(722, 21);
            lblDataDevolucao.TabIndex = 6;
            lblDataDevolucao.Text = "Data Devolução:";
            // 
            // dtpDevolucao
            // 
            dtpDevolucao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDevolucao.Font = new Font("Segoe UI", 11F);
            dtpDevolucao.Location = new Point(12, 239);
            dtpDevolucao.Margin = new Padding(0, 0, 0, 12);
            dtpDevolucao.Name = "dtpDevolucao";
            dtpDevolucao.Size = new Size(722, 27);
            dtpDevolucao.TabIndex = 7;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Top;
            flowButtons.AutoSize = true;
            flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowButtons.Controls.Add(btnSalvar);
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Location = new Point(267, 291);
            flowButtons.Margin = new Padding(0, 12, 0, 0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(212, 42);
            flowButtons.TabIndex = 8;
            flowButtons.WrapContents = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(70, 130, 180);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(3, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 36);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
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
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmEmprestimoEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tableMain);
            MinimumSize = new Size(600, 400);
            Name = "FrmEmprestimoEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Empréstimo";
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
        private Label lblAluno;
        private TextBox txtAluno;
        private Label lblLivro;
        private TextBox txtLivro;
        private Label lblDataEmprestimo;
        private DateTimePicker dtpEmprestimo;
        private Label lblDataDevolucao;
        private DateTimePicker dtpDevolucao;
        private FlowLayoutPanel flowButtons;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}

