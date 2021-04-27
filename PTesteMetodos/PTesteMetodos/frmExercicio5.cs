using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int numero1 = Convert.ToInt32(txtNumero1);
            int numero2 = Convert.ToInt32(txtNumero2);
            int sorteio;
            sorteio = rand.Next(numero1, numero2);
            MessageBox.Show(Convert.ToString(sorteio));
        }
    }
}
