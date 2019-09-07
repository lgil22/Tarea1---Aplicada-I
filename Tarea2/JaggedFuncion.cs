using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
    public class JaggedFuncion
    {
        public void funtion()
        {
            // Variables necesarias
            int[] numeros = new int[5];
            int n = 0;
            string valor = "";
            // Pedimos los numeros
            for (n = 0; n < 5; n++)
            {
                Console.Write("Ingrese un numero: ");
                valor = Console.ReadLine();
                numeros[n] = Convert.ToInt32(valor);
            }
            // Invocamos a la funcion
            Imprime(numeros);
        }
        // Esta es la función de impresion
        static void Imprime(int[] arreglo)
        {
            int n = 0;
            for (n = 0; n < 5; n++)
            {
                Console.WriteLine("\nEl numero es" + arreglo[n]);
            }
            Console.ReadKey();
        }

     }

}
