using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_ex07
{
    class Caixa
    {
        public double saldo;

        public void sacar(double dinheiro)
        {
            saldo = saldo - dinheiro;
        }

        public void depositar(double dinheiro)
        {
            saldo = saldo + dinheiro;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}
