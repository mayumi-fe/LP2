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
    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCargo.Text == "" || txtInscrição.Text == "" || txtProdução.Text == "" || txtGratificação.Text == "" || txtSalário.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                double producao, salario, gratificacao, salbruto = 0;
                if (double.TryParse(txtProdução.Text, out producao) && double.TryParse(txtSalário.Text, out salario) && double.TryParse(txtGratificação.Text, out gratificacao))
                {
                    if (producao >= 100 && producao < 120)
                    {
                        salbruto = salario + (salario * 0.05) + gratificacao;
                    }
                    if (producao >= 120 && producao < 150)
                    {
                        salbruto = salario + (salario * 0.15) + gratificacao;
                    }
                    if (producao >= 150)
                    {
                        salbruto = salario + (salario * 0.25) + gratificacao;
                    }
                    if (salbruto>=7000)
                    {
                        if (gratificacao == 0 || producao < 150)
                            salbruto = 7000;
                    }

                    txtSalarioBruto.Text = salbruto.ToString("N2");
                    
                }

                else
                {
                    MessageBox.Show("Digite valores válidos.");
                }
                    
                       
            }
        }
    }
}
