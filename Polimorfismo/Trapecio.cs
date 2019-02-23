using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Trapecio:IFigura
    {
        public double BaseMin { get; set; }
        public double BaseMax { get; set; }
        public double Altura { get; set; }

        public double CalcularArea()
        {
            return (Altura * (BaseMin + BaseMax)) / 2;
        }
        public void DatosTrapecio()
        {
            Console.WriteLine("Base menor: {0}, Base menor: {1}, Altura: {2}", BaseMin, BaseMax, Altura);
        }
    }
}
