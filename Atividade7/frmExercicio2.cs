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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            string Stringona = rchtxtFrase.Text;

            int totalBranco = 0;          
                  
          
            foreach(char letra in Stringona)
            {
                if(letra ==' ')
                {
                    totalBranco += 1;
                }
                
                
            }
            MessageBox.Show("A Frase "+ rchtxtFrase.Text +"tem " + totalBranco.ToString() + " espaços em branco");

        }

        private void btnQuantidadeR_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string Stringona = rchtxtFrase.Text;
            foreach (char c in Stringona)
            {
                if (c == 'R' || c == 'r')
                {
                    cont += 1;
                }
            }
            MessageBox.Show("Número de vezes que ocorre a letra R: " + cont);
        }

        private void btnParLetras_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string stringona = rchtxtFrase.Text;
            for (int x = 1; x < stringona.Length; x++)
            {
                if (Char.Equals(rchtxtFrase.Text[x], rchtxtFrase.Text[x - 1]))
                {
                    cont += 1;
                }
            }
            MessageBox.Show("Número de ocorrência de pares de letras: " + cont);
        }
    }
}
    

