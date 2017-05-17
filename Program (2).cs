using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampada lamp = new Lampada();
            int i;
            string trocar;

            do
            {
                Random rnd = new Random();
                int r = rnd.Next(1, 5);
                do
                {
                    if (lamp.estado)
                        Console.WriteLine("A lâmpada está: ligada");
                    else
                        Console.WriteLine("A lâmpada está: desligada");

                    Console.WriteLine("O que quer fazer?");
                    Console.WriteLine("1. Acender");
                    Console.WriteLine("2. Apagar");
                    Console.WriteLine("3. Sair");
                    i = Convert.ToInt16(Console.ReadLine());

                    if (lamp.vezes <= r)
                    {
                        if (i == 1)
                            lamp.Ligar();
                        else if (i == 2)
                            lamp.Desligar();
                    }
                    else
                    {
                        Console.WriteLine("A lâmpada queimou");
                        i = 3;
                    }
                } while (i < 3);

                Console.WriteLine("Deseja trocar a lampada?(s/n)");
                trocar = Console.ReadLine();
            } while (trocar=="s");
        }
    }
}
