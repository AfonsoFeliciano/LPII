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
    public partial class Resultados : ModeloForm
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            //criação do resultado foi feito no loading form1
            dgvResultados.DataSource = dados.dt;
        }
    }
}
