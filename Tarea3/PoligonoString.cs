using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea3
{
    class PoligonoString
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }
        public PoligonoString()
        {
        }
        public PoligonoString(Double Perimetro, Double Apotema)

        {
            this.Perimetro = Perimetro;
            this.Apotema = Apotema;
        }

        public double Area
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 15; Apotema = 3.25; }
        }

        public static void main()
        {
            PoligonoString p = new PoligonoString();
            Console.WriteLine(p.ToString());
        }
    }
}

