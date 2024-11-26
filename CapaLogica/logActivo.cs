using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logActivo
    {

        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logActivo _instancia = new logActivo();

        // Propiedad para acceder a la instancia única
        public static logActivo Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entActivo> ListarRegistroActivo()
        {
            return datActivo.Instancia.ListarActivos();
        }
        public bool InsertarActivo(entActivo activo)
        {
            return datActivo.Instancia.InsertarActivo(activo);
        }
        public bool ActualizarActivo(entActivo activo)
        {
            // Aquí puedes agregar validaciones de negocio si es necesario
            if (string.IsNullOrEmpty(activo.Nombre) || string.IsNullOrEmpty(activo.Marca))
            {
                throw new Exception("El nombre y la marca son campos obligatorios");
            }

            // Si el tipo de activo es Equipo, validar que tenga número de serie
            if (activo.TipoActivo.Id == 1 && string.IsNullOrEmpty(activo.Serie))
            {
                throw new Exception("Los equipos deben tener número de serie");
            }

            // Si el tipo de activo es Unidad de Transporte, validar que tenga placa
            if (activo.TipoActivo.Id == 2 && string.IsNullOrEmpty(activo.Placa))
            {
                throw new Exception("Las unidades de transporte deben tener número de placa");
            }

            return datActivo.Instancia.ActualizarActivo(activo);
        }
        public void DeshabilitarActivo(entActivo ac)
        {
            datActivo.Instancia.DeshabilitarActivo(ac);
        }

    }
}
