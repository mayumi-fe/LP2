using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, pesoIdeal;
            
            if (mskbxAltura.MaskCompleted && mskbxPeso.MaskCompleted)
            {
                if (double.TryParse(mskbxAltura.Text, out altura) && double.TryParse(mskbxPeso.Text, out peso))
                {
                    altura = altura / 100;
                    peso = peso / 1000;

                    if (rbtnFeminino.Checked)
                    {
                        pesoIdeal = (62.1 * altura) - 44.7;
                    }
                    else
                    {
                        pesoIdeal = (72.7 * altura) - 58;
                    }

                    if (Convert.ToString(peso) == Convert.ToString(pesoIdeal))
                    {
                        MessageBox.Show("Você está com peso ideal", "Peso Ideal");
                    }
                    else
                    {
                        if (peso > pesoIdeal)
                        {
                            MessageBox.Show("Regime obrigatório já", "Peso Ideal");
                        }
                        else
                        {
                            MessageBox.Show("Coma bastante massas e doces", "Peso Ideal");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencher todos os campos", "AVISO");
            }
        }
    }
}
