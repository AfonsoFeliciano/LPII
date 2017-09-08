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
    public partial class Calcular : ModeloForm
    {
        public Calcular()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {   //receber valores do formulário
                float peso, altura;
                //verificar se os campos sao vazios
                if(txtPeso.Text.Equals("") || txtAltura.Text.Equals("")) {
                    MessageBox.Show("Digite os campos corretamente.");
                    txtPeso.Focus();
                } else {

                    peso = float.Parse(txtPeso.Text);
                    altura = float.Parse(txtAltura.Text);
                    IMC imc = new IMC();
                    imc.calcularImc(peso, altura);
                    MessageBox.Show(imc.r);
                }



            }
            catch (Exception ex) { MessageBox.Show("Ocorreu um erro.\n" + ex.Message); }

            
        }
    }
}
