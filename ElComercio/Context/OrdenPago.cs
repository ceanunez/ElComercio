using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class OrdenPago
    {
        public int id { get; set; }
        public decimal monto { get; set; }
        public Moneda moneda { get; set; }
        public EstadoOrdenPago estado { get; set; }
        public DateTime fecha { get; set; }
    }
}
