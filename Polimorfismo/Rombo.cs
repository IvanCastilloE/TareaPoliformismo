using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Rombo:IFigura
    {
        public double DiagonalMin { get; set; }
        public double DiagonalMax { get; set; }

        public double CalcularArea()
        {
            return (DiagonalMax * DiagonalMin) / 2;
        }
        public void DatosRombo()
        {
            Console.WriteLine("Diagonal menor: {0}, Diagonal mayor: {1}", DiagonalMin, DiagonalMax);
        }
    }
}
