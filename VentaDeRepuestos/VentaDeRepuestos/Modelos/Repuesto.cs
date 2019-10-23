using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeRepuestos.Modelos
{
    class Repuesto
    {
        public string ID_Repuesto { get; set; }
        public string ID_PARTEVEH { get; set; }
        public string ID_MARCAVEH { get; set; }
        public string Nombe { get; set; }
        public string Descripcion { get; set; }
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public string Descuento { get; set; }
        public string NumMotor { get; set; }
        public string NumChasis { get; set; }
        public string NumVin { get; set; }
    }
}
