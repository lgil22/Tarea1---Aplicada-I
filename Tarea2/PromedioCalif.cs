using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
   public class PromedioCalif
    {
        public void promcal()
        {
            // Variables necesarias
            int cantidad = 0; // Cantidad de alumnos
            int n = 0; // Variable de control de ciclo
            string valor = "";
            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 100.00f;// Variable para la calificación mínima
            float maxima = 0.0f; // Variable para la calificación maxima
        // Pedimos la cantidad de alumnos
            Console.WriteLine("Ingrese la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            // Creamos el arreglo
            float[] calif = new float[cantidad];
            // Capturamos la información
            for (n = 0; n < cantidad; n++)
            {
                Console.Write("Ingrese la calificación: ");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
            }
            // Encontramos el promedio
            for (n = 0; n < cantidad; n++)
            {
                suma += calif[n];
            }
            promedio = suma / cantidad;
            
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] < minima)
                    minima = calif[n];
            }
           
            for (n = 0; n < cantidad; n++)
            {
                if (calif[n] > maxima)
                    maxima = calif[n];
            }
            // Desplegamos los resultados
            Console.WriteLine("\nEl promedio es: " + promedio);
            Console.WriteLine("La calificación minima es: " + minima);
            Console.WriteLine("La calificación maxima es: " + maxima);
            Console.ReadKey();
        } // Cierre de main
    } // Cierre de la clase

}
