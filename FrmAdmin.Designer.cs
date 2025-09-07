////namespace BibliotecaQRCode
//{
//    partial class FrmAdmin
//{
//    /// <summary>
//    ///  Required designer variable.
//    /// </summary>
//    private System.ComponentModel.IContainer components = null;

//    /// <summary>
//    ///  Clean up any resources being used.
//    /// </summary>
//    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//    protected override void Dispose(bool disposing)
//    {
//        if (disposing && (components != null))
//        {
//            components.Dispose();
//        }
//        base.Dispose(disposing);
//    }

//    #region Windows Form Designer generated code

//    /// <summary>
//    ///  Required method for Designer support - do not modify
//    ///  the contents of this method with the code editor.
//    /// </summary>
//    private void InitializeComponent()
//    {
//        this.mainLayout = new TableLayoutPanel();
//        this.panelMenu = new FlowLayoutPanel();
//        this.btnAlunos = new Button();
//        this.btnLivros = new Button();
//        this.btnEmprestimos = new Button();
//        this.dgvDados = new DataGridView();
//        this.panelBotoes = new FlowLayoutPanel();
//        this.btnAdicionar = new Button();
//        this.btnEditar = new Button();
//        this.btnExcluir = new Button();
//        this.mainLayout.SuspendLayout();
//        this.panelMenu.SuspendLayout();
//        ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
//        this.panelBotoes.SuspendLayout();
//        this.SuspendLayout();
//        // 
//        // mainLayout
//        // 
//        this.mainLayout.ColumnCount = 2;
//        this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
//        this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
//        this.mainLayout.RowCount = 2;
//        this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
//        this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
//        this.mainLayout.Dock = DockStyle.Fill;
//        this.mainLayout.Controls.Add(this.panelMenu, 0, 0);
//        this.mainLayout.SetRowSpan(this.panelMenu, 2);
//        this.mainLayout.Controls.Add(this.dgvDados, 1, 0);
//        this.mainLayout.Controls.Add(this.panelBotoes, 1, 1);
//        this.mainLayout.Location = new Point(0, 0);
//        this.mainLayout.Name = "mainLayout";
//        this.mainLayout.Size = new Size(1200, 700);
//        this.mainLayout.TabIndex = 0;
//        // 
//        // panelMenu
//        // 
//        this.panelMenu.Dock = DockStyle.Fill;
//        this.panelMenu.FlowDirection = FlowDirection.TopDown;
//        this.panelMenu.WrapContents = false;
//        this.panelMenu.Padding = new Padding(10);
//        this.panelMenu.BackColor = Color.LightSteelBlue;
//        this.panelMenu.Controls.Add(this.btnAlunos);
//        this.panelMenu.Controls.Add(this.btnLivros);
//        this.panelMenu.Controls.Add(this.btnEmprestimos);
//        this.panelMenu.Location = new Point(3, 3);
//        this.panelMenu.Name = "panelMenu";
//        this.panelMenu.Size = new Size(194, 694);
//        this.panelMenu.TabIndex = 0;
//        // 
//        // btnAlunos
//        // 
//        this.btnAlunos.Text = "Alunos";
//        this.btnAlunos.Size = new Size(160, 50);
//        this.btnAlunos.Margin = new Padding(5);
//        this.btnAlunos.BackColor = Color.White;
//        this.btnAlunos.Click += new EventHandler(this.btnAlunos_Click);
//        // 
//        // btnLivros
//        // 
//        this.btnLivros.Text = "Livros";
//        this.btnLivros.Size = new Size(160, 50);
//        this.btnLivros.Margin = new Padding(5);
//        this.btnLivros.BackColor = Color.White;
//        this.btnLivros.Click += new EventHandler(this.btnLivros_Click);
//        // 
//        // btnEmprestimos
//        // 
//        this.btnEmprestimos.Text = "Empréstimos";
//        this.btnEmprestimos.Size = new Size(160, 50);
//        this.btnEmprestimos.Margin = new Padding(5);
//        this.btnEmprestimos.BackColor = Color.White;
//        this.btnEmprestimos.Click += new EventHandler(this.btnEmprestimos_Click);
//        // 
//        // dgvDados
//        // 
//        this.dgvDados.Dock = DockStyle.Fill;
//        this.dgvDados.BackgroundColor = Color.White;
//        this.dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//        this.dgvDados.Location = new Point(203, 3);
//        this.dgvDados.Name = "dgvDados";
//        this.dgvDados.Size = new Size(994, 624);
//        this.dgvDados.TabIndex = 1;
//        // 
//        // panelBotoes
//        // 
//        this.panelBotoes.Dock = DockStyle.Fill;
//        this.panelBotoes.FlowDirection = FlowDirection.RightToLeft;
//        this.panelBotoes.Padding = new Padding(10);
//        this.panelBotoes.Controls.Add(this.btnAdicionar);
//        this.panelBotoes.Controls.Add(this.btnEditar);
//        this.panelBotoes.Controls.Add(this.btnExcluir);
//        this.panelBotoes.Location = new Point(203, 633);
//        this.panelBotoes.Name = "panelBotoes";
//        this.panelBotoes.Size = new Size(994, 64);
//        this.panelBotoes.TabIndex = 2;
//        // 
//        // btnAdicionar
//        // 
//        this.btnAdicionar.Text = "Adicionar";
//        this.btnAdicionar.Size = new Size(120, 40);
//        this.btnAdicionar.Margin = new Padding(5);
//        this.btnAdicionar.BackColor = Color.SteelBlue;
//        this.btnAdicionar.ForeColor = Color.White;
//        this.btnAdicionar.Click += new EventHandler(this.btnAdicionar_Click);
//        // 
//        // btnEditar
//        // 
//        this.btnEditar.Text = "Editar";
//        this.btnEditar.Size = new Size(120, 40);
//        this.btnEditar.Margin = new Padding(5);
//        this.btnEditar.BackColor = Color.Goldenrod;
//        this.btnEditar.ForeColor = Color.White;
//        this.btnEditar.Click += new EventHandler(this.btnEditar_Click);
//        // 
//        // btnExcluir
//        // 
//        this.btnExcluir.Text = "Excluir";
//        this.btnExcluir.Size = new Size(120, 40);
//        this.btnExcluir.Margin = new Padding(5);
//        this.btnExcluir.BackColor = Color.Firebrick;
//        this.btnExcluir.ForeColor = Color.White;
//        this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);
//        // 
//        // FrmAdmin
//        // 
//        this.AutoScaleDimensions = new SizeF(8F, 20F);
//        this.AutoScaleMode = AutoScaleMode.Font;
//        this.ClientSize = new Size(1200, 700);
//        this.Controls.Add(this.mainLayout);
//        this.Name = "FrmAdmin";
//        this.Text = "Painel Administrativo";
//        this.mainLayout.ResumeLayout(false);
//        this.panelMenu.ResumeLayout(false);
//        ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
//        this.panelBotoes.ResumeLayout(false);
//        this.ResumeLayout(false);

//    }

//    #endregion

//    private TableLayoutPanel mainLayout;
//    private FlowLayoutPanel panelMenu;
//    private Button btnAlunos;
//    private Button btnLivros;
//    private Button btnEmprestimos;
//    private DataGridView dgvDados;
//    private FlowLayoutPanel panelBotoes;
//    private Button btnAdicionar;
//    private Button btnEditar;
//    private Button btnExcluir;
//}
//}

//aqui
namespace BibliotecaQRCode
{
    partial class FrmAdmin
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            panelMenu = new FlowLayoutPanel();
            btnAlunos = new Button();
            btnLivros = new Button();
            btnEmprestimos = new Button();
            dgvDados = new DataGridView();
            panelBotoes = new FlowLayoutPanel();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            mainLayout.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            panelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(panelMenu, 0, 0);
            mainLayout.Controls.Add(dgvDados, 1, 0);
            mainLayout.Controls.Add(panelBotoes, 1, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Margin = new Padding(3, 2, 3, 2);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            mainLayout.Size = new Size(1050, 525);
            mainLayout.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSteelBlue;
            panelMenu.Controls.Add(btnAlunos);
            panelMenu.Controls.Add(btnLivros);
            panelMenu.Controls.Add(btnEmprestimos);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.FlowDirection = FlowDirection.TopDown;
            panelMenu.Location = new Point(3, 2);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(9, 8, 9, 8);
            mainLayout.SetRowSpan(panelMenu, 2);
            panelMenu.Size = new Size(169, 521);
            panelMenu.TabIndex = 0;
            panelMenu.WrapContents = false;
            // 
            // btnAlunos
            // 
            btnAlunos.BackColor = Color.White;
            btnAlunos.Location = new Point(13, 12);
            btnAlunos.Margin = new Padding(4, 4, 4, 4);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(140, 38);
            btnAlunos.TabIndex = 0;
            btnAlunos.Text = "Alunos";
            btnAlunos.UseVisualStyleBackColor = false;
            btnAlunos.Click += btnAlunos_Click_1;
            // 
            // btnLivros
            // 
            btnLivros.BackColor = Color.White;
            btnLivros.Location = new Point(13, 58);
            btnLivros.Margin = new Padding(4, 4, 4, 4);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(140, 38);
            btnLivros.TabIndex = 1;
            btnLivros.Text = "Livros";
            btnLivros.UseVisualStyleBackColor = false;
            btnLivros.Click += btnLivros_Click_1;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.BackColor = Color.White;
            btnEmprestimos.Location = new Point(13, 104);
            btnEmprestimos.Margin = new Padding(4, 4, 4, 4);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(140, 38);
            btnEmprestimos.TabIndex = 2;
            btnEmprestimos.Text = "Empréstimos";
            btnEmprestimos.UseVisualStyleBackColor = false;
            btnEmprestimos.Click += btnEmprestimos_Click_1;
            // 
            // dgvDados
            // 
            dgvDados.BackgroundColor = Color.White;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Dock = DockStyle.Fill;
            dgvDados.Location = new Point(178, 2);
            dgvDados.Margin = new Padding(3, 2, 3, 2);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(869, 468);
            dgvDados.TabIndex = 1;
            // 
            // panelBotoes
            // 
            panelBotoes.BackColor = Color.LightSteelBlue;
            panelBotoes.Controls.Add(btnAdicionar);
            panelBotoes.Controls.Add(btnEditar);
            panelBotoes.Controls.Add(btnExcluir);
            panelBotoes.Dock = DockStyle.Fill;
            panelBotoes.FlowDirection = FlowDirection.RightToLeft;
            panelBotoes.Location = new Point(178, 474);
            panelBotoes.Margin = new Padding(3, 2, 3, 2);
            panelBotoes.Name = "panelBotoes";
            panelBotoes.Padding = new Padding(9, 8, 9, 8);
            panelBotoes.Size = new Size(869, 49);
            panelBotoes.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.SteelBlue;
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(742, 12);
            btnAdicionar.Margin = new Padding(4, 4, 4, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(105, 30);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Goldenrod;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(629, 12);
            btnEditar.Margin = new Padding(4, 4, 4, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 30);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Firebrick;
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(516, 12);
            btnExcluir.Margin = new Padding(4, 4, 4, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 30);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 525);
            Controls.Add(mainLayout);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAdmin";
            Text = "Painel Administrativo";
            mainLayout.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            panelBotoes.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainLayout;
        private FlowLayoutPanel panelMenu;
        private Button btnAlunos;
        private Button btnLivros;
        private Button btnEmprestimos;
        private DataGridView dgvDados;
        private FlowLayoutPanel panelBotoes;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}
