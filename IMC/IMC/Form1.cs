using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calcular c = new Calcular(); //classe do form calcular
            c.MdiParent = this; //definição de child para o form1
            c.Show(); //abertura sem modal
            //c.ShowDialog(); //trava a tela até que seja fechada         
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void calcularImcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
