using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entMaterial
    {
        public int Id { get; set; }
        public  string Nombre { get; set; }
        public int Stock { get; set; }
        public string Medidas { get; set; }
        public string Marca { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
