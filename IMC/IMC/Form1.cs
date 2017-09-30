using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            Calcular c = new Calcular(); //classe de form calcular 
            c.MdiParent = this; //definido um child para o form1
            c.Show(); //abertura sem modal
            //c.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dados.CriarTabela();
            GravarTexto gt = new GravarTexto();
            gt.lerTexto();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultadosStripMenuItem1_Click(object sender, EventArgs e)
        {
            Resultado resultado = new Resultado();
            resultado.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void tabelaIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tabela tabela = new Tabela();
            tabela.ShowDialog();
        }
    }
}
