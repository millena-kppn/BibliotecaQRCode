//namespace BibliotecaQRCode
//{
//    partial class FrmEscolha
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
//            btnAdmin = new Button();
//            btnAluno = new Button();
//            SuspendLayout();
//            // 
//            // btnAdmin
//            // 
//            btnAdmin.Location = new Point(440, 329);
//            btnAdmin.Margin = new Padding(5);
//            btnAdmin.Name = "btnAdmin";
//            btnAdmin.Size = new Size(283, 137);
//            btnAdmin.TabIndex = 1;
//            btnAdmin.Text = "Administrador";
//            btnAdmin.UseVisualStyleBackColor = true;
//            btnAdmin.Click += btnAdmin_Click;
//            // 
//            // btnAluno
//            // 
//            btnAluno.Location = new Point(440, 182);
//            btnAluno.Margin = new Padding(5);
//            btnAluno.Name = "btnAluno";
//            btnAluno.Size = new Size(283, 137);
//            btnAluno.TabIndex = 2;
//            btnAluno.Text = "Aluno";
//            btnAluno.UseVisualStyleBackColor = true;
//            btnAluno.Click += btnAluno_Click;
//            // 
//            // FrmEscolha
//            // 
//            AutoScaleDimensions = new SizeF(11F, 25F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.LightSteelBlue;
//            BackgroundImage = Properties.Resources.livros_capa_02;
//            ClientSize = new Size(1257, 750);
//            Controls.Add(btnAluno);
//            Controls.Add(btnAdmin);
//            Margin = new Padding(5);
//            Name = "FrmEscolha";
//            Text = "FrmEscolha";
//            ResumeLayout(false);
//        }

//        #endregion

//        private Button btnAdmin;
//        private Button btnAluno;
//    }
//}
//aqui
namespace BibliotecaQRCode
{
    partial class FrmEscolha
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
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.btnAluno = new Button();
            this.btnAdmin = new Button();
            this.SuspendLayout();
            // 
            // FrmEscolha
            // 
            this.AutoScaleDimensions = new SizeF(11F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.BackgroundImage = Properties.Resources.livros_capa_02;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(900, 600);
            this.MinimumSize = new Size(600, 400);
            this.Name = "FrmEscolha";
            this.Text = "Escolha o tipo de acesso";
            this.StartPosition = FormStartPosition.CenterScreen;

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));

            // 
            // btnAluno
            // 
            this.btnAluno.Dock = DockStyle.Fill;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAluno.BackColor = Color.FromArgb(52, 152, 219);
            this.btnAluno.ForeColor = Color.White;
            this.btnAluno.FlatStyle = FlatStyle.Flat;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.Margin = new Padding(40, 10, 40, 10);
            this.btnAluno.Click += new EventHandler(this.btnAluno_Click);

            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = DockStyle.Fill;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAdmin.BackColor = Color.FromArgb(231, 76, 60);
            this.btnAdmin.ForeColor = Color.White;
            this.btnAdmin.FlatStyle = FlatStyle.Flat;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.Margin = new Padding(40, 10, 40, 10);
            this.btnAdmin.Click += new EventHandler(this.btnAdmin_Click);

            // 
            // Add controls
            // 
            this.tableLayoutPanel1.Controls.Add(this.btnAluno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdmin, 0, 2);
            this.Controls.Add(this.tableLayoutPanel1);

            this.ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdmin;
        private Button btnAluno;
    }
}
