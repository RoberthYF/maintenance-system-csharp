using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOperario
    {
        #region Singleton
        // Implementación del patrón Singleton
        private static readonly logOperario _instancia = new logOperario();
        public static logOperario Instancia
        {
            get
            {
                return logOperario._instancia;
            }
        }
        #endregion Singleton

        #region Métodos

        // Listar Operarios
        public List<entOperario> ListarOperario()
        {
            return datOperario.Instancia.ListarOperario();
        }

        // Insertar Operarios
        public void InsertarOperario(entOperario op)
        {
            datOperario.Instancia.InsertarOperario(op);
        }

        // Editar Operario
        public void EditarOperario(entOperario op)
        {
            datOperario.Instancia.EditarOperario(op);
        }

        // Deshabilitar Operario
        public void DeshabilitarOperario(entOperario op)
        {
            datOperario.Instancia.DeshabilitarOperario(op);
        }
        public List<entOperario> ListarOperarioCBX()
        {

            return datOperario.Instancia.ListarOperarioCBX();

        }
        #endregion Métodos
    }
}
