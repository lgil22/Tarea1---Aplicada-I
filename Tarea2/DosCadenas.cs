using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
    class DosCadenas
    {
        public static string[] Ordernar(string[] cadenas)
        {
            return (from c in cadenas orderby c select c).ToArray<string>();
        }
        public void cadens()
        {
            string[] cadenas = { "Joyeria", "Avion", "Responsabilidad", "Piratas" };

            Console.WriteLine("\t \t Palabras desordenadas:");
            foreach (string s in cadenas)
                Console.WriteLine(s);

            cadenas = Ordernar(cadenas);

            Console.WriteLine("\n  \t \t Palabras ordenadas:");
            foreach (string s in cadenas)
                Console.WriteLine(s);
            Console.ReadKey();
        }

    }
    
}