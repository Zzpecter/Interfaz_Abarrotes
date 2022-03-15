using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ViLocalidad
    {
        public int id_localidad { get; set; }
        public int id_departamento { get; set; }
        public string nombre_localidad { get; set; }
    }

    public class Localidad : ViLocalidad
    {
        public string usuario_registro { get; set; }
    }
}
