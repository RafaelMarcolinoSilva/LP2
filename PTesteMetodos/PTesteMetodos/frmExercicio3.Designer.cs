namespace PTesteMetodos
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRemoverOcorrencia = new System.Windows.Forms.Button();
            this.btnRemoverReplace = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(97, 24);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(100, 88);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(352, 24);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(352, 80);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnRemoverOcorrencia
            // 
            this.btnRemoverOcorrencia.Location = new System.Drawing.Point(100, 197);
            this.btnRemoverOcorrencia.Name = "btnRemoverOcorrencia";
            this.btnRemoverOcorrencia.Size = new System.Drawing.Size(80, 42);
            this.btnRemoverOcorrencia.TabIndex = 4;
            this.btnRemoverOcorrencia.Text = "Remover Ocorrências";
            this.btnRemoverOcorrencia.UseVisualStyleBackColor = true;
            this.btnRemoverOcorrencia.Click += new System.EventHandler(this.btnRemoverOcorrencia_Click);
            // 
            // btnRemoverReplace
            // 
            this.btnRemoverReplace.Location = new System.Drawing.Point(324, 196);
            this.btnRemoverReplace.Name = "btnRemoverReplace";
            this.btnRemoverReplace.Size = new System.Drawing.Size(75, 53);
            this.btnRemoverReplace.TabIndex = 5;
            this.btnRemoverReplace.Text = "Remover Ocorrências (replace)";
            this.btnRemoverReplace.UseVisualStyleBackColor = true;
            this.btnRemoverReplace.Click += new System.EventHandler(this.btnRemoverReplace_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(519, 195);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(75, 54);
            this.btnInverte.TabIndex = 6;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 325);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemoverReplace);
            this.Controls.Add(this.btnRemoverOcorrencia);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnRemoverOcorrencia;
        private System.Windows.Forms.Button btnRemoverReplace;
        private System.Windows.Forms.Button btnInverte;
    }
}