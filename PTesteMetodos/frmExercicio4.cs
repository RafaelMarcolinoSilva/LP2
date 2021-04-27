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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCaracterNumerico_Click(object sender, EventArgs e)
        {
            //isNumber
            //for
            //rchtxtFrase.Text.
            string stringona = rchtxtFrase.Text;
            int palavra = Convert.ToInt16(stringona);
            int comprimento = stringona.Length;
            int totalNumerico = 0;
            int contador = 0;
            for (contador = 0; contador < comprimento; contador++)
                if(palavra is int)
                {
                    totalNumerico += 1;
                }
            MessageBox.Show(string.Format(Convert.ToString(stringona)));
            MessageBox.Show("possui");
            MessageBox.Show(string.Format(Convert.ToString(totalNumerico)));
            MessageBox.Show("números");
        }
    }

}
                