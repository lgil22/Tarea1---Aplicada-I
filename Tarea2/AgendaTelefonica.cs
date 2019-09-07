using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
    class AgendaTelefonica
    {
        public void agend()
        {
            int cant;
            Console.Write("Cuantos numero desea ingresar a la agenda: ");
            cant = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Agenda(cant);
        }

        public void Agenda(int cant)
        {
            //string nombre;
            //int tel;
            string[] nom = new string[cant];
            int[] num = new int[cant];

            for (int x = 0; x < cant; x++)
            {
                Console.Write("Introduce el nombre: ");
                nom[x] = Convert.ToString(Console.ReadLine());
                Console.Write("Introduce el telefono: ");
                num[x] = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
        
            }
            for (int x = 0; x < nom.Length; x++)
            {

                Console.WriteLine("Nombre: " + nom[x] + "\t\t\tTelefono: " + num[x]);
                Console.ReadKey();
            }
        }

    }
}
