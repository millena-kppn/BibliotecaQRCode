namespace BibliotecaQRCode
{
    partial class FrmDevolucao
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
            txtCodigoQR = new TextBox();
            btnDevolver = new Button();
            lblDescricao = new Label();
            SuspendLayout();
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(174, 77);
            txtCodigoQR.Margin = new Padding(2);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(103, 23);
            txtCodigoQR.TabIndex = 0;
            txtCodigoQR.KeyDown += txtCodigoQR_KeyDown_1;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(187, 126);
            btnDevolver.Margin = new Padding(2);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(76, 22);
            btnDevolver.TabIndex = 1;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(123, 49);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(209, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Após bipar seu livro click em devolver.";
            // 
            // FrmDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(509, 270);
            Controls.Add(lblDescricao);
            Controls.Add(btnDevolver);
            Controls.Add(txtCodigoQR);
            Margin = new Padding(2);
            Name = "FrmDevolucao";
            Text = "FrmDevolucao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigoQR;
        private Button btnDevolver;
        private Label lblDescricao;
    }
}