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
        private string resultado = "";
            
        //construtor da classe
        public IMC() { }
        public void calcularImc(float peso, float altura)
        {
            
           r = verificarTabela(peso/(altura*altura));
        }

        private string verificarTabela(float imc)
        {
            //processamento aqui.
            //Abaixo do peso
            if (imc < 18.5f) 
               return "Abaixo do peso";
            
            //peso normal
            else if (imc >= 18.5f && imc < 25) 
                return "Peso Normal";
    
            //maior = a 25 e menor que 30
            //acima do peso
            else if (imc >=25 && imc < 30)
                return "acima do peso";
           
            //maior que 30
            //Obeso
            else
                return "Obeso";
            
        }


        //geters and seters
        public string r
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }
}
