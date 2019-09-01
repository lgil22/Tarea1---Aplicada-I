using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp4
{
    public class Mult
    {
      public void tabMult()
        {
            int n;
            Console.Write("Ingrese el numero que desea saber la tabla de multiplicacion: ");
            n = Int32.Parse(Console.ReadLine());

            for (int x = 1; x < 11; x++)
            {
                Console.WriteLine(x + " x " + n + " = " + x * n + "\n");

            }
            Console.Read();
            /*new Potencia().Elevado();
            Console.ReadLine();
            new EdadPromedio().Prom();*/
        }
    }
}
