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
    public class datTipoActivo
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly datTipoActivo _instancia = new datTipoActivo();

        // Propiedad para acceder a la instancia única
        public static datTipoActivo Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion
        public List<entTipoActivo> ListarTipoActivo()
        {
            SqlCommand cmd = null;
            List<entTipoActivo> lista = new List<entTipoActivo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoActivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoActivo tpact = new  entTipoActivo();
                    tpact.Id = Convert.ToInt32(dr["id"]);
                    tpact.Nombre = dr["Nombre"].ToString();
                    lista.Add(tpact);
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
