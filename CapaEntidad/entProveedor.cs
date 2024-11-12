using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        public int idProveedor { get; set; }
        public string nombreProveedor { get; set; }
        public string RUC { get; set; }
        public string direccion { get; set; }
        public string rubro { get; set; }
        public int idCiudad { get; set; }
        public bool estProveedor { get; set; }
    }
}
