using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViContactoTelefono
    {
        public int id_contacto_telefono { get; set; }
        public int id_contacto { get; set; }
        public string codigo_pais { get; set; }
        public string numero { get; set; }
    }

    public class ContactoTelefono : ViContactoTelefono
    {
        public string usuario_registro { get; set; }
    }
}
