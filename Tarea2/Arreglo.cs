using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
    public class Arreglo
    {
        public void list()
        {
            int cant;
            Console.Write("Digite la cantidad de notas que desea ingresar: ");
            cant = Int32.Parse(Console.ReadLine());
            Notas(cant);
        }

        static void Notas(int cant)
        {
            ArrayList nota = new ArrayList();
            int num, mayor = 0, menor = 9999;
            float prom = 0;

            for (int x = 1; x <= cant; x++)
            {
                Console.WriteLine("\nIngrese la nota [" + x + "] del estudiante");
                num = Int32.Parse(Console.ReadLine());
                nota.Add(num);

                if (num > mayor)
                    mayor = num;

                if (num < menor)
                    menor = num;
                prom += num;


            }
            prom = prom / cant;
            Console.WriteLine("La nota Mayor es: " + mayor);
            Console.WriteLine("La nota Menor es: " + menor);
            Console.WriteLine("EL promedio es: " + prom);
            Console.ReadKey();
        }
    }


}

