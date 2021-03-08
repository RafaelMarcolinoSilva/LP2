using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPesoCertoM
{
    
    public partial class Form1 : Form
    {
        double Resultado;

        public Form1()

            
        {
            
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pesoAtual;
            pesoAtual = Convert.ToDouble(txtPesoAtual.Text);

            if (CbxSexo.Text == "Masculino")
            {

                Resultado = (72.7 * Convert.ToDouble(txtAltura.Text) - 58);
                txtPesoIdeal.Text = Resultado.ToString();
            }
            else
            {
                Resultado = (62.1 * Convert.ToDouble(txtAltura.Text) - 44.7);
                txtPesoIdeal.Text = Resultado.ToString();

            }
           

            if (Resultado < pesoAtual)
                MessageBox.Show("Dieta já!!");

            if (Resultado == pesoAtual)
                MessageBox.Show("Peso Ideal!!");

            if (Resultado > pesoAtual)
                MessageBox.Show("A vontade para comer o que quiser!!");
            
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            double altura;

            if (!double.TryParse(txtAltura.Text, out altura))
                MessageBox.Show("Altura Inválida");

        }

        private void txtPesoAtual_TextChanged(object sender, EventArgs e)
        {
            double peso;
            if (!double.TryParse(txtPesoAtual.Text, out peso))
                MessageBox.Show("Peso Inválido");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesoIdeal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPesoAtual.Clear();
            txtPesoIdeal.Clear();
        }
    }
}   
