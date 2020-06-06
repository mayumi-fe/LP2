using System;
using System.Collections.Generic;
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
    public partial class formExercicio7 : Form
    {
        public formExercicio7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string nome;
            string[] nomes = new string[6];
            int[] tamanho = new int[6];
            int n;

            for(n=0; n<6; n++)
            {
                nome = Interaction.InputBox("Digite um nome:  ", "Entrada de dados");
                nomes[n] = nome;
                tamanho[n] = nome.Replace(" ", "").Length;
                lstbxNomes.Items.Add("O nome " + nomes[n] + "tem " + tamanho[n] + " caracteres.");
            }

        }
    }
}
