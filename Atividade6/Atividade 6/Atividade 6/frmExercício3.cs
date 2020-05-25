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
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if(txtSequencia.Text.Length>50)
            {
                MessageBox.Show("Digite uma sequência de caracteres menor.");
            }
            else
            {
                
                string frase;
                string fraseinvertida = "";
                frase = txtSequencia.Text.ToUpper();
                frase = frase.Replace(" ", "");
                string cAcento = "ÄÅÁÂÀÃÉÊËÈÍÎÏÌÖÓÔÒÕÜÚÛ";
                string sAcento = "AAAAAAEEEEIIIIOOOOOUUU";
                for (int i=0; i<cAcento.Length; i++)
                {
                    frase = frase.Replace(cAcento[i].ToString(), sAcento[i].ToString());
                }
                char[] sequencia = frase.ToCharArray();
                Array.Reverse(sequencia);
                foreach (char c in sequencia)
                    fraseinvertida = fraseinvertida + c.ToString();
                if(String.Equals(frase,fraseinvertida))
                {
                    MessageBox.Show("É um palíndromo");
                }
                else
                {
                    MessageBox.Show("Não são iguais");
                }


                //string s = txtPalavra1.Text;
                //char[] arr = s.ToCharArray(); // joga string para um array
               // Array.Reverse(arr); //invertendo o array
                //s = ""; //limpa a string para voltar a palavra invertida
                //foreach (char c in arr)
               //     s = s + c.ToString();
              //  MessageBox.Show(s);
                //string ss = txtPalavra1.Text;
                //char[] arr1 = ss.ToCharArray();
                //Array.Reverese(arr1);
                //ss=new string(arr1);
                //MessageBox.Show(ss);
            }
        }
    }
}
