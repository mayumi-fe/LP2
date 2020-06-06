using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";
            for (var x=0; x<20; x++)
            {
                valor = Interaction.InputBox("Digite um valor na posição: " +(x+1),
                    "Entrada de dados" );
                // inputbox é uma caixinha que abre quando clica
                if (valor == "")
                    break;
                if(int.TryParse(valor, out Vetor[x]))
                {
                    // auxiliar = auxiliar + "\n" + Vetor[x].ToString();
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                }
                else
                {
                    MessageBox.Show("Número inválido!");
                    x--;
                    //x-- para ler novamente o que deu erro
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";
            for(var x=0; x<20; x++)
            {
                valor = Interaction.InputBox("Entre com os valores:" +
                    (x + 1), "Entrada de dados");
                if (valor == "")
                    break;
                if(!int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Digite um número válido!");
                    x--;
                }
            }

            Array.Reverse(Vetor);

            for (var x = 0; x < 20; x++)
                auxiliar = auxiliar + "\n" + Vetor[x];

            //for (var x = 19; x >= 0; x--)
            //    auxiliar = auxiliar + "\n" + Vetor[x].ToString();

            MessageBox.Show(auxiliar);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[] VetorPreco = new double[10];
            double[] VetorQuant = new double[10];
            double faturamento = 0;
            string valor = "";

            for (var x = 0; x < 10; x++)
            {
                valor = Interaction.InputBox("Digite a quantidade vendida do produto " + (x + 1),
                    "Entrada de dados");
                if (double.TryParse(valor, out VetorQuant[x]))
                {
                    while (true)
                    {
                        valor = Interaction.InputBox("Digite o preço do produto " + (x + 1),
                        "Entrada de dados");
                        if (double.TryParse(valor, out VetorPreco[x]))
                            break;
                        else
                            MessageBox.Show("Digite um preco válido!");
                    }
                    faturamento = faturamento + (VetorQuant[x] * VetorPreco[x]);
                }

                else 
                { 
                    MessageBox.Show("Digite uma quantidade válida!");
                    x--;
                }
            }

            MessageBox.Show(faturamento.ToString("N2"));

        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise",
                "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
                Total += Alunos[I].Length;
            MessageBox.Show(Total.ToString());
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            ArrayList Alunos = new ArrayList();
            Alunos.Add("Ana");
            Alunos.Add("André");
            Alunos.Add("Débora");
            Alunos.Add("Fátima");
            Alunos.Add("João");
            Alunos.Add("Janete");
            Alunos.Add("Otávio");
            Alunos.Add("Marcelo");
            Alunos.Add("Pedro");
            Alunos.Add("Thais");

            Alunos.Remove("Otávio");

            foreach (string nomes in Alunos)
            {
                MessageBox.Show(nomes);
            }
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            int i, j;
            string nota = "";
            double media;

            for (i = 0; i < 20; i++)
            {
                double soma = 0;

                for (j = 0; j < 3; j++)
                {
                    nota = Interaction.InputBox("Digite a nota " + (j + 1) +
                          " do aluno " + (i + 1), "Entrada das notas");

                    if (double.TryParse(nota, out notas[i, j]))
                    {
                        soma = soma + (notas[i, j]);
                    }

                    else
                    {
                        MessageBox.Show("Digite uma nota válida");
                        j--;
                    }
                }
                media = (soma)/3;
                MessageBox.Show("Média do aluno " + (i + 1) + ": " + media.ToString("N2"));
            }

        }

        private void btnExercicio_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["formExercicio7"];
            if (fc != null)
                fc.Close();
            // não cria várias vezes na memória
            formExercicio7 frm1 = new formExercicio7();
            frm1.Show();
        }
    }
}
