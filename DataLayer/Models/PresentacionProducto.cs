using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViPresentacionProducto
    {
        public int id_presentacion_producto { get; set; }
        public int id_unidad_presentacion { get; set; }
        public string nombre_presentacion { get; set; }
    }

    public class ViPresentacionUnidad : ViPresentacionProducto
    {
        public string nombre_medida { get; set; }
        public Double multiplicador_kg { get; set; }
    }

    public class PresentacionProducto : ViPresentacionProducto
    {
        public string usuario_registro { get; set; }
    }
}
