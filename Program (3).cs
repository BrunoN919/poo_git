using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            IMC imc = new IMC();

            Console.Write("Peso: ");
            imc.peso = float.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            imc.altura = float.Parse(Console.ReadLine());

            Console.WriteLine(imc.altura + imc.peso);

            float indice = imc.GetIMC(imc.peso, imc.altura);

            Console.WriteLine("Seu IMC é "+ indice + " e você está "+ imc.GetCategoria(indice) );


        }
    }
}
