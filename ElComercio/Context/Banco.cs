﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Banco
    {
        public int id { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public List<Sucursal> Sucursales;

        public Banco()
        {
            Sucursales = new List<Sucursal>();
        }
    }
}
