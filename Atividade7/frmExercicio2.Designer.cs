namespace Atividade7
{
    partial class frmExercicio2
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnEspacoBranco = new System.Windows.Forms.Button();
            this.btnQuantidadeR = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(329, 96);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(152, 83);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnEspacoBranco
            // 
            this.btnEspacoBranco.Location = new System.Drawing.Point(116, 279);
            this.btnEspacoBranco.Name = "btnEspacoBranco";
            this.btnEspacoBranco.Size = new System.Drawing.Size(75, 40);
            this.btnEspacoBranco.TabIndex = 1;
            this.btnEspacoBranco.Text = "Espaços em Branco";
            this.btnEspacoBranco.UseVisualStyleBackColor = true;
            this.btnEspacoBranco.Click += new System.EventHandler(this.btnEspacoBranco_Click);
            // 
            // btnQuantidadeR
            // 
            this.btnQuantidadeR.Location = new System.Drawing.Point(329, 279);
            this.btnQuantidadeR.Name = "btnQuantidadeR";
            this.btnQuantidadeR.Size = new System.Drawing.Size(75, 40);
            this.btnQuantidadeR.TabIndex = 2;
            this.btnQuantidadeR.Text = "Quantidade de \"R\"";
            this.btnQuantidadeR.UseVisualStyleBackColor = true;
            this.btnQuantidadeR.Click += new System.EventHandler(this.btnQuantidadeR_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Location = new System.Drawing.Point(528, 279);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(98, 40);
            this.btnParLetras.TabIndex = 3;
            this.btnParLetras.Text = "Quantidade de Pares de Letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.btnParLetras_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnQuantidadeR);
            this.Controls.Add(this.btnEspacoBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnEspacoBranco;
        private System.Windows.Forms.Button btnQuantidadeR;
        private System.Windows.Forms.Button btnParLetras;
    }
}