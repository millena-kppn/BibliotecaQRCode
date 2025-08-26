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
            btnAlunos.Location = new Point(19, 163);
            btnAlunos.Margin = new Padding(5, 5, 5, 5);
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(178, 135);
            btnAlunos.TabIndex = 0;
            btnAlunos.Text = "Alunos";
            btnAlunos.UseVisualStyleBackColor = true;
            btnAlunos.Click += btnAlunos_Click_1;
            // 
            // btnLivros
            // 
            btnLivros.Location = new Point(19, 308);
            btnLivros.Margin = new Padding(5, 5, 5, 5);
            btnLivros.Name = "btnLivros";
            btnLivros.Size = new Size(178, 135);
            btnLivros.TabIndex = 1;
            btnLivros.Text = "Livros";
            btnLivros.UseVisualStyleBackColor = true;
            btnLivros.Click += btnLivros_Click_1;
            // 
            // btnEmprestimos
            // 
            btnEmprestimos.Location = new Point(19, 453);
            btnEmprestimos.Margin = new Padding(5, 5, 5, 5);
            btnEmprestimos.Name = "btnEmprestimos";
            btnEmprestimos.Size = new Size(178, 135);
            btnEmprestimos.TabIndex = 2;
            btnEmprestimos.Text = "Empréstimos";
            btnEmprestimos.UseVisualStyleBackColor = true;
            btnEmprestimos.Click += btnEmprestimos_Click_1;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(259, 40);
            dgvDados.Margin = new Padding(5, 5, 5, 5);
            dgvDados.Name = "dgvDados";
            dgvDados.RowHeadersWidth = 66;
            dgvDados.Size = new Size(896, 583);
            dgvDados.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(665, 653);
            btnAdicionar.Margin = new Padding(5, 5, 5, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(157, 77);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(831, 653);
            btnEditar.Margin = new Padding(5, 5, 5, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(157, 77);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(998, 653);
            btnExcluir.Margin = new Padding(5, 5, 5, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(157, 77);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1257, 750);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvDados);
            Controls.Add(btnEmprestimos);
            Controls.Add(btnLivros);
            Controls.Add(btnAlunos);
            Margin = new Padding(5, 5, 5, 5);
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