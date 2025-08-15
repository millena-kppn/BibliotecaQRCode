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
            SuspendLayout();
            // 
            // txtCodigoQR
            // 
            txtCodigoQR.Location = new Point(274, 129);
            txtCodigoQR.Name = "txtCodigoQR";
            txtCodigoQR.Size = new Size(160, 33);
            txtCodigoQR.TabIndex = 0;
            // 
            // btnDevolver
            // 
            btnDevolver.Location = new Point(324, 211);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(120, 37);
            btnDevolver.TabIndex = 1;
            btnDevolver.Text = "Devolver";
            btnDevolver.UseVisualStyleBackColor = true;
            // 
            // FrmDevolucao
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDevolver);
            Controls.Add(txtCodigoQR);
            Name = "FrmDevolucao";
            Text = "FrmDevolucao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigoQR;
        private Button btnDevolver;
    }
}