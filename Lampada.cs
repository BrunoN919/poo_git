using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula04_ex03
{
    class Lampada
    {
        public bool estado = false;
        public int vezes = 0;

        public void Ligar()
        {
            estado = true;
            vezes++;
        }

        public void Desligar()
        {
            estado = false;
        }

        public void Trocar()
        {
            vezes = 0;
            estado = false;
        }

    }
}
