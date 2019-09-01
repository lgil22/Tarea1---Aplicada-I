using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp4
{
    class EdadPromedio
    {
        public void Prom()
        {
            int personas, edad, mayor = 0, menor = 999;
            Console.WriteLine("De cuanto es el grupo de personas ?");
            personas = Int32.Parse(Console.ReadLine());

            for (int x = 0; x < personas; x++)
            {
                Console.Write("Introduzca la edad: ");
                edad = Int32.Parse(Console.ReadLine());

                if (edad > mayor)
                {
                    mayor = edad;
                }

                if (edad < menor)
                {
                    menor = edad;
                }


            }
            Console.WriteLine("El mayor es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
            Console.Read();

        }
    }
}
