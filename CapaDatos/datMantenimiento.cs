using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datMantenimiento
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly datMantenimiento _instancia = new datMantenimiento();

        // Propiedad para acceder a la instancia única
        public static datMantenimiento Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion 


        public bool ValidarMantenimientoPorOperario(int idOperario)
        {

            SqlCommand cmd = null;
            bool valido = true;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spValidarRegistroMantenimientoOperario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOperario", idOperario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    valido= false;
                }
            }
            catch (Exception e)
            {
                valido= false;
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return valido;

        }
        public List<entMantenimiento> ListarMantenimiento()
        {
            SqlCommand cmd = null;
            List<entMantenimiento> lista = new List<entMantenimiento>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMantenimiento rm = new entMantenimiento();
                    rm.Operario = new entOperario();
                    rm.Activo = new entActivo();
                    rm.TipoMantenimiento = new entTipoMantenimiento();
                    rm.Operario.Id = Convert.ToInt32(dr["IdOperario"]);
                    rm.Id = Convert.ToInt32(dr["Id"]);
                    rm.Activo.Nombre = dr["Activo"].ToString();
                    rm.FechaMantenimiento = dr.GetDateTime(dr.GetOrdinal("FechaMantenimiento"));
                    rm.Operario.Nombre = dr["NombreOperario"].ToString();
                    rm.Descripcion = dr["Descripcion"].ToString();
                    rm.TipoMantenimiento.Nombre = dr["TipoMantenimiento"].ToString();
                    rm.Estado = dr.GetBoolean(dr.GetOrdinal("Estado"));
                    lista.Add(rm);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return lista;
        }
        public bool RegistrarMantenimiento(entMantenimiento ma)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMantenimiento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdActivo", ma.Activo.Id);
                cmd.Parameters.AddWithValue("@IdOperario", ma.Operario.Id);
                cmd.Parameters.AddWithValue("@Descripcion", ma.Descripcion);
                cmd.Parameters.AddWithValue("@IdTipoMantenimiento", ma.TipoMantenimiento.Id);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return inserta;
        }
    }
}
