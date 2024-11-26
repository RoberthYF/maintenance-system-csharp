using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datTipoMantenimiento
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly datTipoMantenimiento _instancia = new datTipoMantenimiento();

        // Propiedad para acceder a la instancia única
        public static datTipoMantenimiento Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion 


        public List<entTipoMantenimiento> ListarTipoMantenimiento()
        {
            SqlCommand cmd = null;
            List<entTipoMantenimiento> lista = new List<entTipoMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoMantenimiento tpmant = new entTipoMantenimiento();
                    tpmant.Id = Convert.ToInt32(dr["id"]);
                    tpmant.Nombre = dr["Nombre"].ToString();
                    lista.Add(tpmant);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
    }
}
