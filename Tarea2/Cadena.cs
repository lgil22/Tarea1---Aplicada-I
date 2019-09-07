using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
   public class Cadena
    {
         public void Palabras()
        {
            int inicio = 1;
            Console.WriteLine("\n\t Función que dado un número regresa una cadena");
            Console.WriteLine("\nIngrese el numero deseado:");
            inicio = Int32.Parse(Console.ReadLine());

            switch (inicio)
            {
                case 1:
                    Console.WriteLine("\n\tHola");
                    break;

                case 2:
                    Console.Write("\n\tBienvenidos");
                    break;

                case 3:
                    Console.Write("\n\tA la orden");
                    break;

                case 4:
                    Console.Write("\n\tFelicidades");

                    break;
                case 5:
                    Console.Write("\n\tGracias");
                    break;

                case 6:
                    Console.Write("\n\tHasta Luego");
                    break;

                case 7:
                    Console.Write("\n\tNos vemos pronto");
                    break;

                default:
                    Console.WriteLine("Numero Fuera de rango intente de nuevo");
                    break;
            }

            Console.ReadKey();
        }
    }
}
