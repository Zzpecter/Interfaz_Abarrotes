using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViDisposicion
    {
        public int id_salida_producto { get; set; }
        public int id_usuario { get; set; }
        public int id_motivo { get; set; }
        public int id_producto { get; set; }
        public decimal cantidad { get; set; }
        public string comentario { get; set; }
        public DateTime fecha { get; set; }
    }

    public class ViDisposicionCompleto : ViDisposicion
    {
        public string descripcion_motivo { get; set; }
        public string usuario { get; set; }
        public string producto { get; set; }
    }

    public class Disposicion : ViDisposicion
    {
        public string usuario_registro { get; set; }
    }
}
