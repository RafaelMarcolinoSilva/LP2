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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnNumeroH_Click(object sender, EventArgs e)
        {
            double N;
            double H = 0;
            double cont;

            if ((double.TryParse(txtbxNumeroH.Text, out N)))
            {
                for (cont = 1; cont <= N; cont++)
                {
                    H = H + (1 / cont);
                }

                txtbxNumeroH.Text = Math.Round(H, 2).ToString();
            }
            else if (txtbxNumeroH.Text == "")
            {
                MessageBox.Show("Campo N vazio!!");
            }
            else
            {
                MessageBox.Show("Informe apenas números");
            }
        
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbxNumeroH.Clear();
        }
    }
}
