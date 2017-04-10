using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;
namespace Context
{
    public class DA
    {
        public List<Banco> Bancos;
        public List<Sucursal> Sucursales;
        public List<OrdenPago> OrdenesPago;
        public List<Moneda> Monedas;
        public List<EstadoOrdenPago> Estados;
        public DA()
        {
            Monedas = new List<Moneda>()
            {
                new Moneda() { id=1, nombre="Sol" },
                new Moneda() {id=2, nombre="Dólar"}
            };

            Estados = new List<EstadoOrdenPago>()
            {
                new EstadoOrdenPago() { id=1, nombre="Pagada" },
                new EstadoOrdenPago() { id=1, nombre="Declinada" },
                new EstadoOrdenPago() { id=1, nombre="Fallida" },
                new EstadoOrdenPago() { id=1, nombre="Anulada" }
            };

            Sucursales = new List<Sucursal>()
            {
                new Sucursal() { Id = 1, Direccion = "Av Renteria 1211", Nombre = "Sucursal 1", FechaRegistro = DateTime.Today },
                new Sucursal() { Id = 2, Direccion = "Av Renteria 211", Nombre = "Sucursal 2", FechaRegistro = DateTime.Today },
                new Sucursal() { Id = 3, Direccion = "Av Renteria 4211", Nombre = "Sucursal 3", FechaRegistro = DateTime.Today },
                new Sucursal() { Id = 4, Direccion = "Av Renteria 211", Nombre = "Sucursal 4", FechaRegistro = DateTime.Today },
                new Sucursal() { Id = 5, Direccion = "Av Renteria 411", Nombre = "Sucursal 5", FechaRegistro = DateTime.Today }
            };
            Bancos = new List<Banco>()
            {
                new Banco() { id = 1, Direccion = "Av Canada 1222", Fecha = DateTime.Today, Nombre = "Banco 1", Sucursales = Sucursales },
                new Banco() { id = 2, Direccion = "Av Bolivia 222", Fecha = DateTime.Today, Nombre = "Banco 2", Sucursales = Sucursales },
                new Banco() { id = 3, Direccion = "Av Arequipa 6322", Fecha = DateTime.Today, Nombre = "Banco 3", Sucursales = Sucursales },
                new Banco() { id = 4, Direccion = "Av Iquitos = 5222", Fecha = DateTime.Today, Nombre = "Banco 4", Sucursales = Sucursales },
                new Banco() { id = 5, Direccion = "Av Zorritos 2322", Fecha = DateTime.Today, Nombre = "Banco 5", Sucursales = Sucursales }
            };
            OrdenesPago = new List<OrdenPago>()
            {
                new OrdenPago() { id=1, estado = Estados[0], fecha=DateTime.Now, moneda =Monedas[0], monto = 200.3M },
                new OrdenPago() { id=1, estado = Estados[1], fecha=DateTime.Now, moneda =Monedas[1], monto = 1200.3M },
                new OrdenPago() { id=1, estado = Estados[2], fecha=DateTime.Now, moneda =Monedas[0], monto = 300.1M },
                new OrdenPago() { id=1, estado = Estados[1], fecha=DateTime.Now, moneda =Monedas[1], monto = 220M },
                new OrdenPago() { id=1, estado = Estados[1], fecha=DateTime.Now, moneda =Monedas[0], monto = 1100.3M }

            };
        }
    }
}
