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
            this.components = new System.ComponentModel.Container();

            // ----------------------------
            // Controles
            // ----------------------------
            this.tableMain = new TableLayoutPanel();
            this.innerLayout = new TableLayoutPanel();
            this.flowButtons = new FlowLayoutPanel();

            this.lblAluno = new Label();
            this.lblLivro = new Label();
            this.lblStatus = new Label();
            this.lblDataEmprestimo = new Label();
            this.lblDevolucao = new Label();

            this.cbAluno = new ComboBox();
            this.cbLivro = new ComboBox();
            this.cbStatus = new ComboBox();

            this.dtpEmprestimo = new DateTimePicker();
            this.dtpDevolucao = new DateTimePicker();

            this.btnSalvar = new Button();
            this.btnCancelar = new Button();

            this.SuspendLayout();

            // ----------------------------
            // tableMain
            // ----------------------------
            this.tableMain.ColumnCount = 1;
            this.tableMain.RowCount = 3;
            this.tableMain.Dock = DockStyle.Fill;
            this.tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F)); // Topo (opcional)
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F)); // Conteúdo
            this.tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10F)); // Botões
            this.tableMain.Padding = new Padding(12);

            // ----------------------------
            // innerLayout (Conteúdo do Formulário)
            // ----------------------------
            this.innerLayout.ColumnCount = 2;
            this.innerLayout.RowCount = 5;
            this.innerLayout.Dock = DockStyle.Fill;
            this.innerLayout.AutoSize = true;
            this.innerLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.innerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.innerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            for (int i = 0; i < 5; i++)
                this.innerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.innerLayout.Padding = new Padding(12);
            this.innerLayout.GrowStyle = TableLayoutPanelGrowStyle.AddRows;

            // ----------------------------
            // Labels
            // ----------------------------
            Font lblFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);

            this.lblAluno.Text = "Aluno:";
            this.lblAluno.Font = lblFont;
            this.lblAluno.Anchor = AnchorStyles.Left;

            this.lblLivro.Text = "Livro:";
            this.lblLivro.Font = lblFont;
            this.lblLivro.Anchor = AnchorStyles.Left;

            this.lblStatus.Text = "Status:";
            this.lblStatus.Font = lblFont;
            this.lblStatus.Anchor = AnchorStyles.Left;

            this.lblDataEmprestimo.Text = "Data Empréstimo:";
            this.lblDataEmprestimo.Font = lblFont;
            this.lblDataEmprestimo.Anchor = AnchorStyles.Left;

            this.lblDevolucao.Text = "Data Devolução:";
            this.lblDevolucao.Font = lblFont;
            this.lblDevolucao.Anchor = AnchorStyles.Left;

            // ----------------------------
            // ComboBoxes
            // ----------------------------
            this.cbAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbAluno.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.cbLivro.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbLivro.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            // ----------------------------
            // DateTimePickers
            // ----------------------------
            this.dtpEmprestimo.Format = DateTimePickerFormat.Custom;
            this.dtpEmprestimo.CustomFormat = "dd/MM/yyyy";
            this.dtpEmprestimo.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.dtpDevolucao.Format = DateTimePickerFormat.Custom;
            this.dtpDevolucao.CustomFormat = "dd/MM/yyyy";
            this.dtpDevolucao.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            // ----------------------------
            // Botões
            // ----------------------------
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSalvar.BackColor = Color.FromArgb(70, 130, 180);
            this.btnSalvar.ForeColor = Color.White;
            this.btnSalvar.FlatStyle = FlatStyle.Flat;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Size = new Size(120, 40);
            this.btnSalvar.Click += new EventHandler(this.btnSalvar_Click);

            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCancelar.BackColor = Color.Gray;
            this.btnCancelar.ForeColor = Color.White;
            this.btnCancelar.FlatStyle = FlatStyle.Flat;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Size = new Size(120, 40);
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);

            this.flowButtons.FlowDirection = FlowDirection.LeftToRight;
            this.flowButtons.WrapContents = false;
            this.flowButtons.AutoSize = true;
            this.flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.flowButtons.Anchor = AnchorStyles.None; // centraliza
            this.flowButtons.Controls.Add(this.btnSalvar);
            this.flowButtons.Controls.Add(this.btnCancelar);

            // ----------------------------
            // Adiciona controles ao innerLayout
            // ----------------------------
            this.innerLayout.Controls.Add(lblAluno, 0, 0);
            this.innerLayout.Controls.Add(cbAluno, 1, 0);
            this.innerLayout.Controls.Add(lblLivro, 0, 1);
            this.innerLayout.Controls.Add(cbLivro, 1, 1);
            this.innerLayout.Controls.Add(lblStatus, 0, 2);
            this.innerLayout.Controls.Add(cbStatus, 1, 2);
            this.innerLayout.Controls.Add(lblDataEmprestimo, 0, 3);
            this.innerLayout.Controls.Add(dtpEmprestimo, 1, 3);
            this.innerLayout.Controls.Add(lblDevolucao, 0, 4);
            this.innerLayout.Controls.Add(dtpDevolucao, 1, 4);

            // ----------------------------
            // Adiciona innerLayout e flowButtons ao tableMain
            // ----------------------------
            this.tableMain.Controls.Add(innerLayout, 0, 1);
            this.tableMain.Controls.Add(flowButtons, 0, 2);

            // ----------------------------
            // FrmEmprestimoEditar (form)
            // ----------------------------
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightSteelBlue;
            this.ClientSize = new Size(800, 500);
            this.Controls.Add(this.tableMain);
            this.MinimumSize = new Size(650, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Editar Empréstimo";
            this.FormBorderStyle = FormBorderStyle.Sizable;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableMain;
        private TableLayoutPanel innerLayout;
        private FlowLayoutPanel flowButtons;

        private Label lblAluno;
        private Label lblLivro;
        private Label lblStatus;
        private Label lblDataEmprestimo;
        private Label lblDevolucao;

        private ComboBox cbAluno;
        private ComboBox cbLivro;
        private ComboBox cbStatus;

        private DateTimePicker dtpEmprestimo;
        private DateTimePicker dtpDevolucao;

        private Button btnSalvar;
        private Button btnCancelar;
    }
}
