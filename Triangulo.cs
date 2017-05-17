using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Triangulo
    {
        public int l1;
        public int l2;
        public int l3;

        public bool Etriangulo()
        {
            if (l1 < (l2 + l3) &&
                l2 < (l1 + l3) &&
                l3 < (l1 + l2))
                return true;
            else
                return false;
        }
        public string TipoTriangulo()
        {
            if (l1 == l2 || l1 == l3 || l3 == l2)
            {
                if (l1 == l2 && l2 == l3)
                {
                    return "Triangulo Equilatero";
                }
                else
                    return "Triangulo Isoceles";
            }
            else
                return "Triangulo Escaleno";
        }


    }



}
