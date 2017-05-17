using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();
            caixa.depositar(1000);
            
            int opcao;
            do
            {
                double dinheiro;
                Console.WriteLine("Saldo: " + caixa.GetSaldo());
                Console.WriteLine("O que vai fazer?");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Sacar");
                Console.WriteLine("3. Sair");
                Console.Write("Sua opção: ");
                opcao = Convert.ToInt16(Console.ReadLine());
                if(opcao == 1)
                {
                    Console.Write("Qual valor?: ");
                    dinheiro = Convert.ToDouble(Console.ReadLine());
                    caixa.depositar(dinheiro);

                }else if(opcao ==2){

                    Console.Write("Qual valor?: ");
                    dinheiro = Convert.ToDouble(Console.ReadLine());
                    caixa.sacar(dinheiro);
                }
                Console.Clear();
            } while (opcao < 3);
        }
    }
}
