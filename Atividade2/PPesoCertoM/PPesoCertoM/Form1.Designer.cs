namespace PPesoCertoM
{
    partial class Form1
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtPesoAtual = new System.Windows.Forms.TextBox();
            this.txtPesoIdeal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxSexo = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(855, 257);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(164, 29);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sexo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(213, 257);
            this.Altura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(55, 23);
            this.Altura.TabIndex = 3;
            this.Altura.Text = "Altura";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(218, 402);
            this.peso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(89, 23);
            this.peso.TabIndex = 4;
            this.peso.Text = "Peso atual";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(218, 525);
            this.btnCalculo.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(125, 41);
            this.btnCalculo.TabIndex = 5;
            this.btnCalculo.Text = "Peso Ideal";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(855, 643);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(125, 41);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPesoAtual
            // 
            this.txtPesoAtual.Location = new System.Drawing.Point(855, 402);
            this.txtPesoAtual.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesoAtual.Name = "txtPesoAtual";
            this.txtPesoAtual.Size = new System.Drawing.Size(164, 29);
            this.txtPesoAtual.TabIndex = 7;
            this.txtPesoAtual.TextChanged += new System.EventHandler(this.txtPesoAtual_TextChanged);
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.Enabled = false;
            this.txtPesoIdeal.Location = new System.Drawing.Point(855, 529);
            this.txtPesoIdeal.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.Size = new System.Drawing.Size(164, 29);
            this.txtPesoIdeal.TabIndex = 8;
            this.txtPesoIdeal.TextChanged += new System.EventHandler(this.txtPesoIdeal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Peso Ideal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CbxSexo
            // 
            this.CbxSexo.FormattingEnabled = true;
            this.CbxSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.CbxSexo.Location = new System.Drawing.Point(855, 134);
            this.CbxSexo.Name = "CbxSexo";
            this.CbxSexo.Size = new System.Drawing.Size(140, 31);
            this.CbxSexo.TabIndex = 10;
            this.CbxSexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(217, 643);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 45);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 727);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.CbxSexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.txtPesoAtual);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtPesoAtual;
        private System.Windows.Forms.TextBox txtPesoIdeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxSexo;
        private System.Windows.Forms.Button btnLimpar;
    }
}

