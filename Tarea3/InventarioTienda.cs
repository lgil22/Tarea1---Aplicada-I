using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP2.Tarea3
{
   public class InventarioTienda
    {
        public class Inventario
        {
            public string Productos { get; set; }
            public float CostoUnidad { get; set; }
            public float PrecioVenta { get; set; }
            public float PrecioCompra { get; set; }
            public float Ganancia { get; set; }
            public float TotalGanancia { get; set; }
        }

    }
}
