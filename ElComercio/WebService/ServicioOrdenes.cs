using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Context;
using System.Text;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioOrdenes" en el código y en el archivo de configuración a la vez.
    public class ServicioOrdenes : IServicioOrdenes
    {
        
        public List<OrdenPago> GetOrdenPago(int Monedaid)
        {
            List<OrdenPago> Lista = new List<OrdenPago>();
            DA Context = new DA();
            Lista = Context.OrdenesPago.Where(x => x.moneda.id == Monedaid).ToList();
            return Lista;

        }
    }
}
