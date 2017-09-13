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
            Calcular c = new Calcular(); //classe do fora calcular
            c.MdiParent = this; //defindo no child para o fora
            c.Show(); //abertura sem modal
            //c.ShowDialog();//trava a tela até que seja fechada porem com parente pai não funciona
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dados.CriarTabela();//vai na classe dados e cria a tabela - load inicializa
        }
    }
}
