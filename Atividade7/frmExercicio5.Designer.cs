namespace Atividade7
{
    partial class frmExercicio5
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumInscricao = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNumInscricao = new System.Windows.Forms.TextBox();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.btnSalarioBruto = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(106, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblNumInscricao
            // 
            this.lblNumInscricao.AutoSize = true;
            this.lblNumInscricao.Location = new System.Drawing.Point(106, 197);
            this.lblNumInscricao.Name = "lblNumInscricao";
            this.lblNumInscricao.Size = new System.Drawing.Size(105, 13);
            this.lblNumInscricao.TabIndex = 1;
            this.lblNumInscricao.Text = "Número de Inscrição";
            this.lblNumInscricao.Click += new System.EventHandler(this.lblNumInscricao_Click);
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Location = new System.Drawing.Point(106, 259);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(53, 13);
            this.lblProducao.TabIndex = 2;
            this.lblProducao.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(106, 307);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Salário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(331, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(331, 128);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 5;
            // 
            // txtNumInscricao
            // 
            this.txtNumInscricao.Location = new System.Drawing.Point(331, 197);
            this.txtNumInscricao.Name = "txtNumInscricao";
            this.txtNumInscricao.Size = new System.Drawing.Size(100, 20);
            this.txtNumInscricao.TabIndex = 6;
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(331, 252);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(100, 20);
            this.txtProducao.TabIndex = 7;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(106, 128);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo";
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Location = new System.Drawing.Point(109, 362);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(64, 13);
            this.lblGratificacao.TabIndex = 9;
            this.lblGratificacao.Text = "Gratificação";
            this.lblGratificacao.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(331, 307);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(331, 354);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(100, 20);
            this.txtGratificacao.TabIndex = 11;
            // 
            // btnSalarioBruto
            // 
            this.btnSalarioBruto.Location = new System.Drawing.Point(598, 311);
            this.btnSalarioBruto.Name = "btnSalarioBruto";
            this.btnSalarioBruto.Size = new System.Drawing.Size(130, 64);
            this.btnSalarioBruto.TabIndex = 12;
            this.btnSalarioBruto.Text = "Salario Bruto";
            this.btnSalarioBruto.UseVisualStyleBackColor = true;
            this.btnSalarioBruto.Click += new System.EventHandler(this.btnSalarioBruto_Click);
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Location = new System.Drawing.Point(687, 41);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(74, 57);
            this.btnLimparDados.TabIndex = 13;
            this.btnLimparDados.Text = "Limpar Dados";
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(598, 239);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(130, 20);
            this.txtSalarioBruto.TabIndex = 14;
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.btnSalarioBruto);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtNumInscricao);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblNumInscricao);
            this.Controls.Add(this.lblNome);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumInscricao;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNumInscricao;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.Button btnSalarioBruto;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.TextBox txtSalarioBruto;
    }
}