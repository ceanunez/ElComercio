using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioSucursal" en el código y en el archivo de configuración a la vez.
    public class ServicioSucursal : IServicioSucursal
    {
        
        public List<Sucursal> GetSucursales(int IdBanco)
        {
            List<Sucursal> Sucursales = new List<Sucursal>();
            DA Context = new DA();
            Sucursales = Context.Bancos.Where(x => x.id == IdBanco).First().Sucursales;
            return Sucursales;
        }
    }
}
