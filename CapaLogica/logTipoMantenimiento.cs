using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoMantenimiento
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logTipoMantenimiento _instancia = new logTipoMantenimiento();

        // Propiedad para acceder a la instancia única
        public static logTipoMantenimiento Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entTipoMantenimiento> ListarTipoMantenimiento()
        {
            return datTipoMantenimiento.Instancia.ListarTipoMantenimiento();
        }



    }
}
