namespace Atividade7
{
    partial class frmExercicio4
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
            this.txtPalindromo = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalindromo
            // 
            this.txtPalindromo.Location = new System.Drawing.Point(308, 89);
            this.txtPalindromo.MaxLength = 50;
            this.txtPalindromo.Name = "txtPalindromo";
            this.txtPalindromo.Size = new System.Drawing.Size(138, 20);
            this.txtPalindromo.TabIndex = 0;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(211, 223);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 38);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar Palindromo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(445, 223);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtPalindromo);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalindromo;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
    }
}