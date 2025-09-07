//aqui
namespace BibliotecaQRCode
{
    partial class FrmAlunoEditar
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
            lblNome = new Label();
            txtNome = new TextBox();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            lblCurso = new Label();
            txtCurso = new TextBox();
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
            innerLayout.Controls.Add(lblNome, 0, 0);
            innerLayout.Controls.Add(txtNome, 0, 1);
            innerLayout.Controls.Add(lblMatricula, 0, 2);
            innerLayout.Controls.Add(txtMatricula, 0, 3);
            innerLayout.Controls.Add(lblCurso, 0, 4);
            innerLayout.Controls.Add(txtCurso, 0, 5);
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
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Dock = DockStyle.Fill;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNome.Location = new Point(12, 18);
            lblNome.Margin = new Padding(0, 6, 0, 2);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(722, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(12, 41);
            txtNome.Margin = new Padding(0, 0, 0, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(722, 27);
            txtNome.TabIndex = 1;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Dock = DockStyle.Fill;
            lblMatricula.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMatricula.Location = new Point(12, 86);
            lblMatricula.Margin = new Padding(0, 6, 0, 2);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(722, 21);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "Matrícula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMatricula.Font = new Font("Segoe UI", 11F);
            txtMatricula.Location = new Point(12, 109);
            txtMatricula.Margin = new Padding(0, 0, 0, 12);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(722, 27);
            txtMatricula.TabIndex = 3;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Dock = DockStyle.Fill;
            lblCurso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCurso.Location = new Point(12, 154);
            lblCurso.Margin = new Padding(0, 6, 0, 2);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(722, 21);
            lblCurso.TabIndex = 4;
            lblCurso.Text = "Curso:";
            // 
            // txtCurso
            // 
            txtCurso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCurso.Font = new Font("Segoe UI", 11F);
            txtCurso.Location = new Point(12, 177);
            txtCurso.Margin = new Padding(0, 0, 0, 12);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(722, 27);
            txtCurso.TabIndex = 5;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Top;
            flowButtons.AutoSize = true;
            flowButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowButtons.Controls.Add(btnSalvar);
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Location = new Point(267, 228);
            flowButtons.Margin = new Padding(0, 12, 0, 0);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(212, 42);
            flowButtons.TabIndex = 6;
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
            // FrmAlunoEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tableMain);
            MinimumSize = new Size(600, 400);
            Name = "FrmAlunoEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Aluno";
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
        private Label lblNome;
        private Label lblMatricula;
        private Label lblCurso;
        private TextBox txtNome;
        private TextBox txtMatricula;
        private TextBox txtCurso;
        private FlowLayoutPanel flowButtons;
        private Button btnSalvar;
        private Button btnCancelar;
        private TableLayoutPanel innerLayout;
    }
}
