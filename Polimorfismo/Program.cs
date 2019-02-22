using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura f1 = new Circulo { Radio = 5 };
            IFigura f2 = new Rectangulo { Base = 5, Altura = 20 };
            IFigura f3 = new Triangulo { Base = 15, Altura = 10 };

            IFigura[] figuras = new IFigura[] { f1, f2, f3 };

            foreach (var figura in figuras)
            {
                Console.WriteLine(figura.CalcularArea());
            }
            Console.ReadKey();
        }
    }
}
