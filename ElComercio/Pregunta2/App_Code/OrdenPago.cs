using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pregunta2.App_Code
{
    public class OrdenPago
    {
        public int id { get; set; }
        public decimal monto { get; set; }
        public string moneda { get; set; }
        public string estado { get; set; }
        public DateTime fecha { get; set; }
    }
}