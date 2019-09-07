using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp4
{
    public class Potencia
    {
        public void Elevado()
        {
            double resultado = 0;
            double numero = 0;
            double potencia = 0;
            double r = 0;

            Console.WriteLine("Ingrese numero a elevar");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese potencia");
            potencia = int.Parse(Console.ReadLine());
            r = numero;

            for (int i = 0; i < potencia - 1; i++)
            {
                resultado = numero * r;

                numero = resultado;
            }

            Console.Write("Resultado " + resultado);

             Console.Read();
        }
    }
}
