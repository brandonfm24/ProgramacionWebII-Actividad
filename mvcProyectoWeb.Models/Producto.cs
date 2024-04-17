using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoWeb.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadMinima { get; set; }

    }
}
