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
    public partial class frmExercício1 : Form
    {
        public frmExercício1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            if (rchtxtFrase.Text.Length > 100)
                MessageBox.Show("A frase precisa conter menos de 100 caracteres.");
            else
            {
                int contador = 0;
                int x = 0;
                while (x < rchtxtFrase.Text.Length)
                {
                    if (Char.IsWhiteSpace(rchtxtFrase.Text[x]))
                    {
                        contador += 1;
                    }
                    x++;
                }
                MessageBox.Show("Número de espaços em brancos é: " + contador);
            }
        }

        private void btnRs_Click(object sender, EventArgs e)
        {
            if (rchtxtFrase.Text.Length > 100)
                MessageBox.Show("A frase precisa conter menos de 100 caracteres.");
            else
            {
                int numeroR;
                string frase = rchtxtFrase.Text.ToLower();
                numeroR = frase.Split('r').Length - 1;
                MessageBox.Show("Número de R(s): " + numeroR);
            }
        }

        private void btnParesLetras_Click(object sender, EventArgs e)
        {
            if (rchtxtFrase.Text.Length > 100)
                MessageBox.Show("A frase precisa conter menos de 100 caracteres.");
            else
            {
                int pares = 0;
                int x;
                string frase = rchtxtFrase.Text.ToLower();
                for(x=0; x<rchtxtFrase.Text.Length-1; x++)
                {
                    if (frase[x] == frase[x + 1])
                        pares = pares + 1;
                }
                MessageBox.Show("Número de pares de letras: " + pares);
            }
        }
    }
}
