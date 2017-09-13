using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class IMC //método construtor
    {
        public DataTable resultado = null;
        public IMC() { }//construtor da classe
        //método calcular imc
        //verificar na tabela
        public void calcularImc(float peso, float altura, string nome)
        {
            r = dados.InserirTabela(nome, (peso / (altura * altura)), verificarTabela(peso / (altura * altura)));
        }
        private string verificarTabela(float imc)
        {
            if (imc < 18.5f)
                return "Abaixo do peso :(";
            else if (imc >= 18.5f && imc < 25)
                return "Peso ideal :)";
            else if (imc >= 25 && imc < 30)
                return "Acima do peso :/";
            else
                return "Obeso :(";
        }
        //propriedade
        //get
        //set
        public DataTable r
        {
            get { return resultado; }//já chama o resultado da operação
            set { resultado = value; } //passa um valor value
        }

    }
}
    // verificar tabela menor que 18.5 abaixo do peso *** > 18.5 a = 25 peso normal **** > 25 e = 30 acima do peso **** acima de 30 obeso