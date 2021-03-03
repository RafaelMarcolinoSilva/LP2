using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadoraM
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrimeiro_numero.Text, out numero1) &&
               double.TryParse(txtSegundo_numero.Text, out numero2))
            {
                if (numero2 == 0)
                    MessageBox.Show("Digite um número diferente de 0");
                else
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPrimeiro_numero.Clear();
            txtSegundo_numero.Clear();
            txtResultado.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrimeiro_numero.Text, out numero1) &&
               double.TryParse(txtSegundo_numero.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrimeiro_numero.Text, out numero1) &&
                double.TryParse(txtSegundo_numero.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrimeiro_numero.Text, out numero1) &&
               double.TryParse(txtSegundo_numero.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundo_numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
