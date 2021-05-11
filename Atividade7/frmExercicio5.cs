using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblNumInscricao_Click(object sender, EventArgs e)
        {

        }

        private void btnSalarioBruto_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo Nome está vazio!");
            }
            if (txtCargo.Text == "")
            {
                MessageBox.Show("Campo Cargo está vazio!");
            }
            if (txtNumInscricao.Text == "")
            {
                MessageBox.Show("Campo Nº de Inscrição está vazio!");
            }
            if (txtProducao.Text == "")
            {
                MessageBox.Show("Campo Produção está vazio!");
            }
            if (txtSalario.Text == "")
            {
                MessageBox.Show("Campo Salário está vazio!");
            }
            if (txtGratificacao.Text == "")
            {
                MessageBox.Show("Campo Gratificação está vazio!");
            }

            double producao;
            double salario;
            double gratificacao;
            double salBruto;

            double A;
            double B;
            double C;
            double D;

            if ((double.TryParse(txtProducao.Text, out producao) &&
                double.TryParse(txtSalario.Text, out salario) &&
                double.TryParse(txtGratificacao.Text, out gratificacao)))
            {
                A = salario;
                if (producao >= 100)
                {
                    B = 1;
                }
                else
                {
                    B = 0;
                }

                if (producao >= 120)
                {
                    C = 1;
                }
                else
                {
                    C = 0;
                }

                if (producao >= 150)
                {
                    D = 1;
                }
                else
                {
                    D = 0;
                }

                salBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

                if (salBruto > 7000.00 && producao >= 150 && gratificacao > 0)
                {
                    txtSalarioBruto.Text = Math.Round(salBruto, 2).ToString();
                }
                else if (salBruto <= 7000.00)
                {
                    txtSalarioBruto.Text = Math.Round(salBruto, 2).ToString();
                }
                else
                {
                    salBruto = 7000.00;
                    txtSalarioBruto.Text = salBruto.ToString();
                }
            }
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtCargo.Clear();
            txtNumInscricao.Clear();
            txtProducao.Clear();
            txtSalario.Clear();
            txtGratificacao.Clear();
            txtSalarioBruto.Clear();
        }
    }
}
