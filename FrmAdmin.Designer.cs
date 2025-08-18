namespace BibliotecaQRCode
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAlunos = new Button();
            btnLivros = new Button();
            btnEmprestimos = new Button();
            dgvDados = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnAlunos
            // 
            btnAlunos.Location = new Point(12, 98);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(113, 81);
            btnAlunos.TabIndex = 0;
            btnAlunos.Text = "Alunos";
            btnAlunos.UseVisualStyleBackColor = true;
            btnAlunos.Click += btnAlunos_Click_1;
            // 
            // btnLivros
            // 
            btnLivros.Location = new Point(12, 185);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(113, 81);
            btnLivros.TabIndex = 1;
            btnLivros.Text = "Livros";
            btnLivros.UseVisualStyleBackColor = true;
            btnLivros.Click += btnLivros_Click_1;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.Location = new Point(12, 272);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(113, 81);
            btnEmprestimos.TabIndex = 2;
            btnEmprestimos.Text = "Empréstimos";
            btnEmprestimos.UseVisualStyleBackColor = true;
            btnEmprestimos.Click += btnEmprestimos_Click_1;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(165, 24);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(570, 350);
            dgvDados.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(423, 392);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(100, 46);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(529, 392);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 46);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(635, 392);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 46);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvDados);
            Controls.Add(btnEmprestimos);
            Controls.Add(btnLivros);
            Controls.Add(btnAlunos);
            Name = "FrmAdmin";
            Text = "FrmAdmin";
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAlunos;
        private Button btnLivros;
        private Button btnEmprestimos;
        private DataGridView dgvDados;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}