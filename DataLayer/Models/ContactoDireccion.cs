using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViContactoDireccion
    {
        public int id_contacto_direccion { get; set; }
        public int id_contacto { get; set; }
        public int id_localidad { get; set; }
        public string calle { get; set; }
        public string numero_casa { get; set; }
        public string zona { get; set; }
        public string detalles { get; set; }
    }

    public class ContactoDireccion : ViContactoDireccion
    {
        public string usuario_registro { get; set; }
    }
}
