using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMantenimientoPreventivo
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logMantenimientoPreventivo _instancia = new logMantenimientoPreventivo();
        // Propiedad pública para acceder a la instancia
        public static logMantenimientoPreventivo Instancia
        {
            get
            {
                return _instancia;
            }
        }
        // Constructor privado para evitar la instanciación directa
        private logMantenimientoPreventivo() { }
        #endregion Singleton

        #region Métodos
        /// <summary>
        /// Lista las unidades de transporte activas
        /// </summary>
        /// <returns>Lista de unidades de transporte</returns>
        public List<entMantenimientoPreventivo> listarMantenimientoPreventivo()
        {
            return datMantenimientoPreventivo.Instancia.listarMantenimientoPreventivo();
        }

        /// <summary>
        /// Inserta una nueva unidad de transporte
        /// </summary>
        /// <param name="MantPre">Entidad de unidad de transporte</param>
        public void RegistrarMantenimientoPreventivo(entMantenimientoPreventivo MantPre)
        {
            datMantenimientoPreventivo.Instancia.RegistrarMantenimientoPreventivo(MantPre);
        }

        /// <summary>
        /// Edita una unidad de transporte existente
        /// </summary>
        /// <param name="MantPre">Entidad de unidad de transporte</param>

        /// <summary>
        /// Deshabilita una unidad de transporte
        /// </summary>
        /// <param name="MantenimientoPreventivo_id">ID de la unidad de transporte</param>
        public void DeshabilitarMantenimientoPre(entMantenimientoPreventivo MantPre)
        {
            datMantenimientoPreventivo.Instancia.DeshabilitarMantenimientoPre(MantPre);
        }
        #endregion Métodos
    }
}
