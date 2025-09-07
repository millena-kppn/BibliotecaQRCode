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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAluno = new Button();
            btnAdmin = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnAluno, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAdmin, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(573, 360);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAluno
            // 
            btnAluno.BackColor = Color.FromArgb(52, 152, 219);
            btnAluno.Dock = DockStyle.Fill;
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAluno.ForeColor = Color.White;
            btnAluno.Location = new Point(25, 6);
            btnAluno.Margin = new Padding(25, 6, 25, 6);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(523, 132);
            btnAluno.TabIndex = 0;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = false;
            btnAluno.Click += btnAluno_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(231, 76, 60);
            btnAdmin.Dock = DockStyle.Fill;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(25, 222);
            btnAdmin.Margin = new Padding(25, 6, 25, 6);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(523, 132);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Administrador";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // FrmEscolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.livros_capa_02;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(573, 360);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(388, 256);
            Name = "FrmEscolha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Escolha o tipo de acesso";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdmin;
        private Button btnAluno;
    }
}
