using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp3
{
    public class ParImpar
    {
        public void parImp()
        {
            int num;
            Console.WriteLine("Introduzca el numero deseado");
            num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Numero es par");
                Console.Read();
            }
            else
            {
                Console.WriteLine("No es par");
                Console.Read();
                /*new NumSemana().Dias();
                Console.ReadLine();
                new PoligonoRegular().Opcion();
                Console.ReadLine();*/

            }

        }
    }
}
