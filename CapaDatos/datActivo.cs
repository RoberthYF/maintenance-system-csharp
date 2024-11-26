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
    public class datActivo
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly datActivo _instancia = new datActivo();

        // Propiedad para acceder a la instancia única
        public static datActivo Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entActivo> ListarActivos()
        {
            SqlCommand cmd = null;
            List<entActivo> lista = new List<entActivo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarRegistroActivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entActivo ac = new entActivo();
                        ac.TipoActivo = new entTipoActivo();

                        ac.Id = dr.GetInt32(dr.GetOrdinal("Id"));
                        ac.TipoActivo.Id = dr.GetInt32(dr.GetOrdinal("IdTipoActivo"));
                        ac.Nombre = dr["Nombre"].ToString();
                        ac.Marca = dr["Marca"].ToString();
                        ac.Serie = dr["Serie"] != DBNull.Value ? dr["Serie"].ToString() : null;
                        ac.Placa = dr["Placa"] != DBNull.Value ? dr["Placa"].ToString() : null;
                        ac.Estado = dr.GetBoolean(dr.GetOrdinal("Estado"));
                        lista.Add(ac);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al cargar activos: {e.Message}");
                throw;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return lista;
        }
        public bool InsertarActivo(entActivo ac)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarActivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdTipoActivo", ac.TipoActivo.Id);
                cmd.Parameters.AddWithValue("@Nombre", ac.Nombre);
                cmd.Parameters.AddWithValue("@Marca", ac.Marca);
                cmd.Parameters.AddWithValue("@Serie", string.IsNullOrEmpty(ac.Serie) ? (object)DBNull.Value : ac.Serie);
                cmd.Parameters.AddWithValue("@Placa", string.IsNullOrEmpty(ac.Placa) ? (object)DBNull.Value : ac.Placa);
                cmd.Parameters.AddWithValue("@Estado", ac.Estado);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                inserta = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
            return inserta;
        }
        public bool ActualizarActivo(entActivo ac)
        {
            SqlCommand cmd = null;
            bool actualiza = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarActivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", ac.Id);
                cmd.Parameters.AddWithValue("@IdTipoActivo", ac.TipoActivo.Id);
                cmd.Parameters.AddWithValue("@Nombre", ac.Nombre);
                cmd.Parameters.AddWithValue("@Marca", ac.Marca);
                cmd.Parameters.AddWithValue("@Serie", string.IsNullOrEmpty(ac.Serie) ? (object)DBNull.Value : ac.Serie);
                cmd.Parameters.AddWithValue("@Placa", string.IsNullOrEmpty(ac.Placa) ? (object)DBNull.Value : ac.Placa);
                cmd.Parameters.AddWithValue("@Estado", ac.Estado);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                actualiza = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return actualiza;
        }
        public bool DeshabilitarActivo(entActivo ac)
        {
            SqlCommand cmd = null;
            bool deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarActivo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ac.Id);

                cn.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                deshabilita = filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return deshabilita;
        }



    }
}
