using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IMC
{
    class IMC
    {
        private DataTable resultado = null;

        public IMC() 
        {
            //construtor da classe
        }
        public void calcularImc(float peso, float altura, string nome)
        {
            r = Dados.InserirTabela(nome, (peso / (altura * altura)), 
                verificarTabela(peso / (altura * altura)));
            GravarTexto gt = new GravarTexto();
            if (!gt.GravaTexto(nome+ ";"+ (peso / (altura * altura)) + ";" + verificarTabela(peso /(altura*altura))));
        }
        private string verificarTabela(float imc)
        {
            if (imc < 18.5)
                return "Abaixo do peso";
            else if (imc >= 18.5 && imc < 25)
                return "Peso Normal";
            else if (imc >= 25 && imc < 30)
                return "Acima do peso";
            else 
                return "Obeso";

            
        }



        public DataTable r 
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
}
