using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.CAp2
{
    public class GradosRadianes
    {
        public void Conversion()
        {
            {
                float num;
                Console.WriteLine("Ingrese cantidad que desea convertir a Radianes ");
                num = float.Parse(Console.ReadLine());
                var resultado = num * 0.017;
                Console.WriteLine("Resultado es: {0}", resultado);
                Console.Read();
               
            }
          
        }
    }
}
