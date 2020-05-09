using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                  
            if (mskbxNome.Text!= "")
            {
                double salario, nfilhos, descontoINSS, salariofamilia, descontoIRPF, salarioliq;

                if (double.TryParse(mskbxSalario.Text, out salario) && double.TryParse(mskbxFilhos.Text, out nfilhos))
                {
                    salario = salario / 100;
                    descontoIRPF = 0;
                    descontoINSS = 0;
                    salariofamilia = 0;

                    if(salario<=800.47)
                    {
                        mskbxAliqINSS.Text = "7,65%";
                        descontoINSS=0.0765 * salario;
                        mskbxAliqIRPF.Text = "0";
                        descontoIRPF = 0;
                        if (salario < 435.53)
                        {
                            salariofamilia = 22.33 * nfilhos;
                        }
                        if(salario>435.52 && salario<=654.61)
                        {
                            salariofamilia = 15.74 * nfilhos;
                        }
                        if (salario > 654.61)
                        {
                            salariofamilia = 0;
                        }
                    }
                    if(salario> 880.47 && salario<=1050)
                    {
                        mskbxAliqINSS.Text = "8,65%";
                        descontoINSS = 0.0865 * salario;
                        mskbxAliqIRPF.Text = "0";
                        descontoIRPF = 0;
                    }
                    if (salario> 1050 && salario <= 1400.77)
                    {
                        mskbxAliqINSS.Text = "9,00%";
                        descontoINSS = 0.09 * salario;
                        if (salario <= 1257.12)
                        {
                            mskbxAliqIRPF.Text = "0";
                            descontoIRPF = 0;
                        }
                        else
                        {
                            mskbxAliqIRPF.Text = "15.00%";
                            descontoIRPF = 0.15*salario;
                        }
                    }
                    if (salario>1400.77 &&  salario <= 2801.56)
                    {
                        mskbxAliqINSS.Text = "11,00%";
                        descontoINSS = 0.11 * salario;
                        if (salario <= 2512.08)
                        {
                            mskbxAliqIRPF.Text = "15.00%";
                            descontoIRPF = 0.15 * salario;
                        }
                        else
                        {
                            mskbxAliqIRPF.Text = "27.05%";
                            descontoIRPF = 0.2705 * salario;
                        }
                    }
                    if (salario > 2801.56)
                    {
                        mskbxAliqINSS.Text = "308.77";
                        descontoINSS = salario-308.77;
                        mskbxAliqIRPF.Text = "27.05%";
                        descontoIRPF = 0.27050 * salario;
                    }

                    salarioliq = salario - descontoINSS - descontoIRPF + salariofamilia;

                    mskbxDescINSS.Text= descontoINSS.ToString("N2");
                    mskbxDescIRPF.Text = descontoIRPF.ToString("N2");
                    mskbxSalarioF.Text = salariofamilia.ToString("N2");
                    mskbxSalarioLiq.Text = salarioliq.ToString("N2");
                    
                    if(chbxCasado.Checked)
                    {
                        lblTexto.Text = "Os descontos do salário do(a) sr(a) " + mskbxNome.Text + " que é casado e tem " + mskbxFilhos.Text + " filhos são:";
                    }
                    else
                    {
                        lblTexto.Text = "Os descontos do salário do(a) sr(a) " + mskbxNome.Text + " que é solteiro(a) e tem " + mskbxFilhos.Text + " filho(s) são:";
                    }
                           

                }

            }
            else
            { 
                MessageBox.Show("Todos os campos devem ser preenchidos", "AVISO");
            }
                
        }
    }
}
