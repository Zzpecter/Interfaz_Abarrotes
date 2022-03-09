using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViMotivo
    {
        public int id_motivo { get; set; }
        public string descripcion_motivo { get; set; }
    }

    public class Motivo : ViMotivo
    {
        public string usuario_registro { get; set; }
    }
}
