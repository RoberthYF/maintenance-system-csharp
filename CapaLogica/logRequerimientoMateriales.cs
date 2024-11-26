using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logRequerimientoMateriales
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logRequerimientoMateriales _instancia = new logRequerimientoMateriales();

        // Propiedad para acceder a la instancia única
        public static logRequerimientoMateriales Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entRequerimientoMateriales> ListarRequerimientoMateriales()
        {
            return datRequerimientoMateriales.Instancia.ListarRequerimientoMateriales();
        }
        public bool InsertarRequerimientoMateriales(entRequerimientoMateriales rm)
        {
           return datRequerimientoMateriales.Instancia.InsertarRequerimientoMateriales(rm);
        
        }
        public bool ActualizarRequerimientoYStock(int id)
        {
            SqlCommand cmd = null;
            bool actualiza = false;
            try
            {
                // Usamos la conexión proporcionada por tu método "Conectar"
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ActualizarRequerimientoYStock", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parametro para el ID del requerimiento
                cmd.Parameters.AddWithValue("@id", id);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    actualiza = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar el requerimiento y stock: " + e.Message);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return actualiza;
        }




    }
}
