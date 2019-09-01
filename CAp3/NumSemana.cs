using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp3
{
    public class NumSemana
    {
        public void Dias()
        {
            int num;
            Console.WriteLine("Introduzca un numero del 1-7 para determinar que dia es");
            num = Int32.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("Hoy es Domingo");
                Console.Read();
            }
            else
                if (num == 2)
            {
                Console.WriteLine("Hoy es Lunes");
                Console.Read();
            }

            else
                if (num == 3)
            {
                Console.WriteLine("Hoy es Martes");
                Console.Read();
            }

            else
                if (num == 4)
            {
                Console.WriteLine("Hoy es Miercoles");
                Console.Read();
            }

            else
                if (num == 5)
            {
                Console.WriteLine("Hoy es Jueves");
                Console.Read();
            }

            else
                if (num == 6)
            {
                Console.WriteLine("Hoy es Viernes");
                Console.Read();
            }

            else
            {
                Console.WriteLine("Hoy es Sabado");
                Console.Read();
            }
        }

    }
}
