using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea3
{
   public class PoligonoPropiedades
    {
        public Double Perimetro { get; set; }
        public Double Apotema { get; set; }
        public PoligonoPropiedades()
        {

        }
        public PoligonoPropiedades(Double Perimetro, Double Apotema)

        {
            this.Perimetro = Perimetro;
            this.Apotema = Apotema;
        }

        public double Area
        {
            get { return Perimetro * Apotema / 2; }
            set { Perimetro = 15; Apotema = 3.25; }
        }
    }
}
