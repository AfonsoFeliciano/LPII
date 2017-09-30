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
        /*
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IMC imc = new IMC();
            imc.calcularImc(82f, 1.75f);
            MessageBox.Show(imc.r);
        }*/
    
        
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try 
            {
                float peso, altura;
                String nome;
                if (txtCliente.Text.Equals("")||  txtPeso.Text.Equals("") || txtAltura.Text.Equals(""))
                {
                    MessageBox.Show("Digite os campos corretamente.");
                    txtPeso.Focus();
                }
                else {
                    peso = float.Parse(txtPeso.Text);
                    altura = float.Parse(txtAltura.Text);
                    nome = txtCliente.Text;
                    IMC imc = new IMC();
                    imc.calcularImc(peso, altura, nome);
                    Resultado resultados = new Resultado();
                    Dados.dt = imc.r;
                    resultados.ShowDialog();

                }
            }
            catch {MessageBox.Show("Ocorreu um erro");}
        }

        
    }
}
