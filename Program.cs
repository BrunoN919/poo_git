using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();

            Console.WriteLine("Qual o tamanho do 1º do triangulo?");
            t.l1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qual o tamanho do 2º lado do triangulo ?");
            t.l2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Qual o tamanho do 3º lado do triangulo?");
            t.l3 = Convert.ToInt16(Console.ReadLine());

            if (t.Etriangulo())
                Console.WriteLine("As medidas {0}, {1} e {2} formam um triângulo {3}.", t.l1, t.l2, t.l3, t.TipoTriangulo());
            else
                Console.WriteLine("As medidas {0}, {1} e {2} não formam um triângulo.", t.l1, t.l2, t.l3);
        }

    }
}

