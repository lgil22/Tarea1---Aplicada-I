using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea2
{
    class HORAampm
    {
        public void AMPM()
        {
            Console.WriteLine(string.Format("{0:hh:mm:ss tt}", DateTime.Now));
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.ReadKey();
        }
    }
}
