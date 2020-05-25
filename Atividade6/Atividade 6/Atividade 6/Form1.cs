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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercício1 frm1 = new frmExercício1(); 
            frm1.MdiParent = this; 
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercício2 frm2 = new frmExercício2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercício3 frm3 = new frmExercício3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercício4 frm4 = new frmExercício4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
