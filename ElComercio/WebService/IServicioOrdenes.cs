using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Context;

namespace WebService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioOrdenes" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioOrdenes
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "data/{Monedaid}")]
        List<OrdenPago> GetOrdenPago(int MonedaId);
    }
}
