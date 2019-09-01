using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp3
{
    public class AreaPer
    {
        public void Opcion()
        {
            int op;
            Console.WriteLine("1-Calcular Radianes del perimetro regular");
            Console.WriteLine("2-Calcular Area del perimetro regular");
            Console.WriteLine("Que desea realizar...?");
            op = Int32.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    float lados = 0, lado = 0, perimetro;
                    Console.WriteLine("\nIntroduzca numero de Lados: ");
                    lados = float.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca numero de Lado: ");
                    lado = float.Parse(Console.ReadLine());

                    perimetro = lado * lados;
                    Console.WriteLine("El perimetro es: {0} ", perimetro);
                    Console.Read();
                    break;

                case 2:
                    float per, apotema, resul;
                    Console.WriteLine("\nIntroduzca el Perimetro");
                    per = float.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca el Apotema");
                    apotema = float.Parse(Console.ReadLine());

                    resul = per * apotema / 2;
                    Console.WriteLine("El Area es {0}", resul);
                    Console.Read();
                    break;

                default:
                    Console.WriteLine("No existe opcion");
                    Console.Read();
                    break;

            }
            

        }
    }
}
