using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp2
{
    class PoligonoRegular
    {
            static void Main(string[] args)
            {
                float lados = 0, lado = 0, perimetro;
                Console.WriteLine("Introduzca numero de Lados: ");
                lados = float.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca numero de Lado: ");
                lado = float.Parse(Console.ReadLine());

                perimetro = lado * lados;

                Console.WriteLine("El perimetro es: {0} ", perimetro);
                Console.Read();
                new GradosRadianes().Conversion();
                Console.Read();
                new CambioDolarEuro().Cambio();
                Console.Read();
        }
        
    }
}
