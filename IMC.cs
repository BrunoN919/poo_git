using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_ex05
{
    class IMC
    {
        public float peso;
        public float altura;
        

        public float GetIMC(float p, float a)
        {
            return p/(a*a );
           }

        public string GetCategoria(float imc)
        {

            if (imc < 18.5)
                return "abaixo do peso";
            else if (imc >= 18.5 && imc < 25)
                return "com peso normal";
            else if (imc >= 25 && imc < 30)
                return "acima do peso";
            else
                return "Obeso";
        }

       
    }
}
