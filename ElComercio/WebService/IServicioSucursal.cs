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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioSucursal" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioSucursal
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Xml,
        BodyStyle = WebMessageBodyStyle.Wrapped,
        UriTemplate = "xml/{IdBanco}")]
        List<Sucursal> GetSucursales(int IdBanco);
    }
}
