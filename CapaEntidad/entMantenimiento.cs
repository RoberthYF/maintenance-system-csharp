using System;

namespace CapaEntidad
{
    public class entMantenimiento
    {
        public int Id { get; set; }
        public entActivo Activo { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public entOperario Operario { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public entTipoMantenimiento TipoMantenimiento{ get; set; }

    }
}
