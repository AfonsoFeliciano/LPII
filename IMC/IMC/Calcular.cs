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
                string nome; //em 1209
                //verificar se os campos sao vazios
                if (txtCliente.Text.Equals("") || txtAltura.Text.Equals(""))
                {
                    MessageBox.Show("Digite os campos corretamente.");
                    txtCliente.Focus();
                }
                else
                {

                    peso = float.Parse(txtPeso.Text);
                    altura = float.Parse(txtAltura.Text);
                    nome = txtCliente.Text; //em 1209
                    IMC imc = new IMC();
                    imc.calcularImc(peso, altura, nome); //em1209
                    //MessageBox.Show(imc.r);
                    Resultados resultado = new Resultados();
                    dados.dt = imc.r;
                    resultado.ShowDialog();
                    
                }



            }
            catch (Exception ex) { MessageBox.Show("Ocorreu um erro.\n" + ex.Message); }
        }
    }
}
