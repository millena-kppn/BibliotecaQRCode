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
            this.mainLayout = new TableLayoutPanel();
            this.panelMenu = new FlowLayoutPanel();
            this.btnAlunos = new Button();
            this.btnLivros = new Button();
            this.btnEmprestimos = new Button();
            this.dgvDados = new DataGridView();
            this.panelBotoes = new FlowLayoutPanel();
            this.btnAdicionar = new Button();
            this.btnEditar = new Button();
            this.btnExcluir = new Button();
            this.mainLayout.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.mainLayout.Dock = DockStyle.Fill;
            this.mainLayout.Controls.Add(this.panelMenu, 0, 0);
            this.mainLayout.SetRowSpan(this.panelMenu, 2);
            this.mainLayout.Controls.Add(this.dgvDados, 1, 0);
            this.mainLayout.Controls.Add(this.panelBotoes, 1, 1);
            this.mainLayout.Location = new Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new Size(1200, 700);
            this.mainLayout.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = DockStyle.Fill;
            this.panelMenu.FlowDirection = FlowDirection.TopDown;
            this.panelMenu.WrapContents = false;
            this.panelMenu.Padding = new Padding(10);
            this.panelMenu.BackColor = Color.LightSteelBlue;
            this.panelMenu.Controls.Add(this.btnAlunos);
            this.panelMenu.Controls.Add(this.btnLivros);
            this.panelMenu.Controls.Add(this.btnEmprestimos);
            this.panelMenu.Location = new Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new Size(194, 694);
            this.panelMenu.TabIndex = 0;
            // 
            // btnAlunos
            // 
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.Size = new Size(160, 50);
            this.btnAlunos.Margin = new Padding(5);
            this.btnAlunos.BackColor = Color.White;
            this.btnAlunos.Click += new EventHandler(this.btnAlunos_Click_1);
            // 
            // btnLivros
            // 
            this.btnLivros.Text = "Livros";
            this.btnLivros.Size = new Size(160, 50);
            this.btnLivros.Margin = new Padding(5);
            this.btnLivros.BackColor = Color.White;
            this.btnLivros.Click += new EventHandler(this.btnLivros_Click_1);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.Text = "Empréstimos";
            this.btnEmprestimos.Size = new Size(160, 50);
            this.btnEmprestimos.Margin = new Padding(5);
            this.btnEmprestimos.BackColor = Color.White;
            this.btnEmprestimos.Click += new EventHandler(this.btnEmprestimos_Click_1);
            // 
            // dgvDados
            // 
            this.dgvDados.Dock = DockStyle.Fill;
            this.dgvDados.BackgroundColor = Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new Point(203, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new Size(994, 624);
            this.dgvDados.TabIndex = 1;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Dock = DockStyle.Fill;
            this.panelBotoes.FlowDirection = FlowDirection.RightToLeft;
            this.panelBotoes.Padding = new Padding(10);
            this.panelBotoes.Controls.Add(this.btnAdicionar);
            this.panelBotoes.Controls.Add(this.btnEditar);
            this.panelBotoes.Controls.Add(this.btnExcluir);
            this.panelBotoes.Location = new Point(203, 633);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new Size(994, 64);
            this.panelBotoes.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Size = new Size(120, 40);
            this.btnAdicionar.Margin = new Padding(5);
            this.btnAdicionar.BackColor = Color.SteelBlue;
            this.btnAdicionar.ForeColor = Color.White;
            this.btnAdicionar.Click += new EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Text = "Editar";
            this.btnEditar.Size = new Size(120, 40);
            this.btnEditar.Margin = new Padding(5);
            this.btnEditar.BackColor = Color.Goldenrod;
            this.btnEditar.ForeColor = Color.White;
            this.btnEditar.Click += new EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Size = new Size(120, 40);
            this.btnExcluir.Margin = new Padding(5);
            this.btnExcluir.BackColor = Color.Firebrick;
            this.btnExcluir.ForeColor = Color.White;
            this.btnExcluir.Click += new EventHandler(this.btnExcluir_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 700);
            this.Controls.Add(this.mainLayout);
            this.Name = "FrmAdmin";
            this.Text = "Painel Administrativo";
            this.mainLayout.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

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
