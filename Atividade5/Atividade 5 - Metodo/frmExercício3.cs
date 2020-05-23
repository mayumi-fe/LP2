using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_5___Metodo
{
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void btnRemover1_Click(object sender, EventArgs e)
        {
            int posicao;
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            while (posicao > 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) +
                    txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length,
                    txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);
                posicao = txtPalavra1.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemover2_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); // joga string para um array
            Array.Reverse(arr); //invertendo o array
            s = ""; //limpa a string para voltar a palavra invertida
            foreach (char c in arr)
                s = s + c.ToString();
            MessageBox.Show(s);
            //string ss = txtPalavra1.Text;
            //char[] arr1 = ss.ToCharArray();
            //Array.Reverese(arr1);
            //ss=new string(arr1);
            //MessageBox.Show(ss);
        }
    }
}
