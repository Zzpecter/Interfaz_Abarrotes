using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{

    public class ViUnidadPresentacion
    {
        public int id_unidad_presentacion { get; set; }
        public string nombre_medida { get; set; }
        public Double multiplicador_kg { get; set; }
    }

    public class UnidadPresentacion : ViUnidadPresentacion
    {
        public string usuario_registro { get; set; }
    }
}
