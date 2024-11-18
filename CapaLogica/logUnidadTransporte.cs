using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUnidadTransporte
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logUnidadTransporte _instancia = new logUnidadTransporte();
        // Propiedad pública para acceder a la instancia
        public static logUnidadTransporte Instancia
        {
            get
            {
                return _instancia;
            }
        }
        // Constructor privado para evitar la instanciación directa
        private logUnidadTransporte() { }
        #endregion Singleton

        #region Métodos
        /// <summary>
        /// Lista las unidades de transporte activas
        /// </summary>
        /// <returns>Lista de unidades de transporte</returns>
        public List<entUnidadTransporte> ListarUT()
        {
            return datUnidadTransporte.Instancia.ListarUT();
        }

        /// <summary>
        /// Inserta una nueva unidad de transporte
        /// </summary>
        /// <param name="ut">Entidad de unidad de transporte</param>
        public void InsertarUT(entUnidadTransporte ut)
        {
            datUnidadTransporte.Instancia.InsertarUT(ut);
        }

        /// <summary>
        /// Edita una unidad de transporte existente
        /// </summary>
        /// <param name="ut">Entidad de unidad de transporte</param>
        public void EditarUT(entUnidadTransporte ut)
        {
            datUnidadTransporte.Instancia.EditarUT(ut);
        }

        /// <summary>
        /// Deshabilita una unidad de transporte
        /// </summary>
        /// <param name="idUnidadTransporte">ID de la unidad de transporte</param>
        public void DeshabilitarUT(entUnidadTransporte ut)
        {
            datUnidadTransporte.Instancia.DeshabilitarUT(ut);
        }
        #endregion Métodos
    }
}
