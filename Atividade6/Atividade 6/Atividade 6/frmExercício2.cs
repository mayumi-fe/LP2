using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class frmExercício2 : Form
    {
        public frmExercício2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numeroN;
            double numeroH = 0;
            double x;
            
            if (double.TryParse(txtNumeroN.Text, out numeroN) && numeroN>0)
            {
                for(x=0; x <numeroN; x++)
                {
                    numeroH = numeroH + (1 / (x + 1));
                }

                txtNumeroH.Text = numeroH.ToString("N2");
            }
            else
                MessageBox.Show("Valor inválido. Dado precisa ser um número e ser maior que zero");
        }
    }
}
