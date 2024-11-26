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
    public class datMaterial
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly datMaterial _instancia = new datMaterial();

        // Propiedad para acceder a la instancia única
        public static datMaterial Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entMaterial> ListarMaterial()
        {
            SqlCommand cmd = null;
            List<entMaterial> lista = new List<entMaterial>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarMateriales", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        entMaterial ma = new entMaterial();

                        ma.Id = dr.GetInt32(dr.GetOrdinal("Id"));

                        ma.Nombre = dr["Nombre"].ToString();
                        ma.Medidas = dr["Medidas"].ToString();
                        ma.Marca = dr["Marca"].ToString();
                        ma.Stock = dr.GetInt32(dr.GetOrdinal("Stock"));
                        ma.Estado = dr.GetBoolean(dr.GetOrdinal("Estado"));
                        lista.Add(ma);
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


        public bool RegistrarMaterial(entMaterial ma)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RegistrarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", ma.Nombre);
                cmd.Parameters.AddWithValue("@Stock", ma.Stock);
                cmd.Parameters.AddWithValue("@Medidas", ma.Medidas);
                cmd.Parameters.AddWithValue("@Marca", ma.Marca);

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

        public bool EditarMaterial(entMaterial ma)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ma.Id);
                cmd.Parameters.AddWithValue("@Nombre",ma.Nombre);
                cmd.Parameters.AddWithValue("@Stock", ma.Stock);
                cmd.Parameters.AddWithValue("@Medidas", ma.Medidas);
                cmd.Parameters.AddWithValue("@Marca", ma.Marca);
                cmd.Parameters.AddWithValue("@Estado", ma.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
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
            return edita;
        }

        public bool DeshabilitarMaterial(entMaterial ma)
        {
            SqlCommand cmd = null;
            bool deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", ma.Id);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilita = true;
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
            return deshabilita;
        }


    }
}
