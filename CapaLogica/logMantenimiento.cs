using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaLogica
{
    public class logMantenimiento
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logMantenimiento _instancia = new logMantenimiento();

        // Propiedad para acceder a la instancia única
        public static logMantenimiento Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public string ValidarRegistroMantenimiento(entMantenimiento mantenimiento)
        {
            string mensaje = "";
            bool valido = datMantenimiento.Instancia.ValidarMantenimientoPorOperario(mantenimiento.Operario.Id);
            if (!valido)
            {
                mensaje = "ESTE OPERARIO YA REGISTRO UN MANTENIMIENTO EL DIA DE HOY";

            }
            return mensaje;
        }

        public List<entMantenimiento> ListarMantenimiento()
        {
            return datMantenimiento.Instancia.ListarMantenimiento();
        }
        public bool RegistrarMantenimiento(entMantenimiento ma)
        {
            return datMantenimiento.Instancia.RegistrarMantenimiento(ma);
        }
    }
}