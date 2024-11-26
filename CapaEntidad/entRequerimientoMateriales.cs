using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entRequerimientoMateriales
    {
        public int Id { get; set; }
        public DateTime FechaRequerimiento { get; set; }
        public entOperario Operario { get; set; }
        public entMaterial Material { get; set; }

        public int Cantidad { get; set; }
        public DateTime? FechaIngreso { get; set; }

        public int IdEstado { get; set; }
    }
}
