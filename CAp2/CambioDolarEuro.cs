using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp2
{
    class CambioDolarEuro
    {
        public void Cambio()
        {
            double dolares = 0;
            double euros = 0;
            string valor = "";

            Console.WriteLine("Ingrese la taza del dia:");
            valor = Console.ReadLine();
            euros = Convert.ToDouble(valor);
            Console.WriteLine("Ingrese el monto de dolares a convertir a Euros:");
            valor = Console.ReadLine();
            dolares = Convert.ToDouble(valor);
            double conversion = dolares * euros;

            Console.WriteLine("{0} Dolares = {1} Euros", dolares, conversion);
        }
    }
}
