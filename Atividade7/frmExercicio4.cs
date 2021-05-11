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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPalindromo.Clear();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtPalindromo.Text == "")
            {
                MessageBox.Show("Campo está vazio!!");
            }
            else
            {
                string palavra = txtPalindromo.Text;
                string palavraInv = new string(palavra.Reverse().ToArray());

                palavra = palavra.Replace(" ", "");
                palavraInv = palavraInv.Replace(" ", "");

                palavra = palavra.ToLower();
                palavraInv = palavraInv.ToLower();

                if (String.Compare(palavra, palavraInv, true) == 0)
                {
                    MessageBox.Show("É Palíndromo\n" + palavraInv);
                }
                else
                {
                    MessageBox.Show("Não é Palíndromo\n" + palavraInv);
                }
            }
        }
    }
}
