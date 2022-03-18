using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViProveedor
    {
        public int id_entidad { get; set; }
        public string nombre { get; set; }
    }

    public class Proveedor : ViProveedor
    {
        public string usuario_registro { get; set; }
    }
}
