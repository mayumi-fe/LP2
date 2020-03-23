using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVERIFICAR_Click(object sender, EventArgs e)
        {
            if(txtA.Text=="" && txtB.Text=="" && txtC.Text=="")
            {
                MessageBox.Show("Preencher todos os campos", "ALERTA");
            }

            else
            {
                double valorA, valorB, valorC;
                if (double.TryParse(txtA.Text, out valorA) && double.TryParse(txtB.Text, out valorB) && double.TryParse(txtC.Text, out valorC))
                {
                    if (((Math.Abs(valorB - valorC)) < valorA && valorA < (valorB + valorC)) && ((Math.Abs(valorA - valorC)) < valorB && valorB < (valorA + valorC)) && ((Math.Abs(valorA - valorB)) < valorC && valorC < (valorA + valorC)))
                    {
                        if(valorA!=valorB && valorA!=valorC && valorB!=valorC)
                        {
                            MessageBox.Show("Triângulo escaleno", "Triângulo");
                        }
                        else
                        {
                            if(valorA == valorB && valorA == valorC && valorB == valorC)
                            {
                                MessageBox.Show("Triângulo equilátero", "Triângulo");
                            }
                            else
                            {
                                MessageBox.Show("Triângulo isósceles", "Triângulo");
                            }
                        }

                    }
                    else
                        MessageBox.Show("Valores não pertencem ao lado de um triângulo", "AVISO");
                }
            }
        }
    }
}
