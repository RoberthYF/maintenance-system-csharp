using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTipoActivo
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logTipoActivo _instancia = new logTipoActivo();

        // Propiedad para acceder a la instancia única
        public static logTipoActivo Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entTipoActivo> ListarTipoActivo()
        {
            return datTipoActivo.Instancia.ListarTipoActivo();
        }
        
    }
}
