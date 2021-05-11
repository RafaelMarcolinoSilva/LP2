namespace Atividade7
{
    partial class frmExercicio3
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
            this.txtbxNumeroH = new System.Windows.Forms.TextBox();
            this.btnNumeroH = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxNumeroH
            // 
            this.txtbxNumeroH.Location = new System.Drawing.Point(282, 102);
            this.txtbxNumeroH.Name = "txtbxNumeroH";
            this.txtbxNumeroH.Size = new System.Drawing.Size(100, 20);
            this.txtbxNumeroH.TabIndex = 0;
            // 
            // btnNumeroH
            // 
            this.btnNumeroH.Location = new System.Drawing.Point(175, 235);
            this.btnNumeroH.Name = "btnNumeroH";
            this.btnNumeroH.Size = new System.Drawing.Size(100, 23);
            this.btnNumeroH.TabIndex = 1;
            this.btnNumeroH.Text = "Gerar Numero H";
            this.btnNumeroH.UseVisualStyleBackColor = true;
            this.btnNumeroH.Click += new System.EventHandler(this.btnNumeroH_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(374, 235);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnNumeroH);
            this.Controls.Add(this.txtbxNumeroH);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxNumeroH;
        private System.Windows.Forms.Button btnNumeroH;
        private System.Windows.Forms.Button btnLimpar;
    }
}