namespace PTesteMetodos
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnCaracterNumerico = new System.Windows.Forms.Button();
            this.btnCaracterBranco = new System.Windows.Forms.Button();
            this.btnCaracterAlfaBetico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(273, 87);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(100, 96);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnCaracterNumerico
            // 
            this.btnCaracterNumerico.Location = new System.Drawing.Point(99, 295);
            this.btnCaracterNumerico.Name = "btnCaracterNumerico";
            this.btnCaracterNumerico.Size = new System.Drawing.Size(87, 50);
            this.btnCaracterNumerico.TabIndex = 1;
            this.btnCaracterNumerico.Text = "Quantidade de Caracteres Numéricos";
            this.btnCaracterNumerico.UseVisualStyleBackColor = true;
            this.btnCaracterNumerico.Click += new System.EventHandler(this.btnCaracterNumerico_Click);
            // 
            // btnCaracterBranco
            // 
            this.btnCaracterBranco.Location = new System.Drawing.Point(286, 294);
            this.btnCaracterBranco.Name = "btnCaracterBranco";
            this.btnCaracterBranco.Size = new System.Drawing.Size(87, 51);
            this.btnCaracterBranco.TabIndex = 2;
            this.btnCaracterBranco.Text = "Primeiro Caractere Branco";
            this.btnCaracterBranco.UseVisualStyleBackColor = true;
            // 
            // btnCaracterAlfaBetico
            // 
            this.btnCaracterAlfaBetico.Location = new System.Drawing.Point(463, 295);
            this.btnCaracterAlfaBetico.Name = "btnCaracterAlfaBetico";
            this.btnCaracterAlfaBetico.Size = new System.Drawing.Size(83, 50);
            this.btnCaracterAlfaBetico.TabIndex = 3;
            this.btnCaracterAlfaBetico.Text = "Quantidade de Caracteres Alfabéticos";
            this.btnCaracterAlfaBetico.UseVisualStyleBackColor = true;
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 424);
            this.Controls.Add(this.btnCaracterAlfaBetico);
            this.Controls.Add(this.btnCaracterBranco);
            this.Controls.Add(this.btnCaracterNumerico);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnCaracterNumerico;
        private System.Windows.Forms.Button btnCaracterBranco;
        private System.Windows.Forms.Button btnCaracterAlfaBetico;
    }
}