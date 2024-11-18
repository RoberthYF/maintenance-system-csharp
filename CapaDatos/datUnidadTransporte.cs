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
    public class datUnidadTransporte
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly datUnidadTransporte _instancia = new datUnidadTransporte();

        // Propiedad para acceder a la instancia única
        public static datUnidadTransporte Instancia
        {
            get
            {
                return _instancia;
            }
        }

        // Constructor privado para evitar instanciación directa
        private datUnidadTransporte() { }
        #endregion Singleton

        #region Métodos

        // Método para listar las unidades de transporte activas
        public List<entUnidadTransporte> ListarUT()
        {
            SqlCommand cmd = null;
            List<entUnidadTransporte> lista = new List<entUnidadTransporte>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUT", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entUnidadTransporte ut = new entUnidadTransporte();
                    ut.idUnidadTransporte = dr["idUnidadTransporte"].ToString();
                    ut.nombreUnidTransporte = dr["nombreUnidTransporte"].ToString();
                    ut.placaUnidTransporte = dr["placaUnidTransporte"].ToString();
                    ut.marca = dr["marca"].ToString();
                    ut.estUT = Convert.ToBoolean(dr["estUT"]);

                    lista.Add(ut);
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

        // Método para insertar una nueva unidad de transporte
        public Boolean InsertarUT(entUnidadTransporte ut)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarUT", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUnidadTransporte", ut.idUnidadTransporte);
                cmd.Parameters.AddWithValue("@nombreUnidTransporte", ut.nombreUnidTransporte);
                cmd.Parameters.AddWithValue("@placaUnidTransporte", ut.placaUnidTransporte);
                cmd.Parameters.AddWithValue("@marca", ut.marca);
                cmd.Parameters.AddWithValue("@estUT", ut.estUT);
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

        // Método para editar una unidad de transporte
        public Boolean EditarUT(entUnidadTransporte ut)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaUT", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUnidadTransporte", ut.idUnidadTransporte);
                cmd.Parameters.AddWithValue("@nombreUnidTransporte", ut.nombreUnidTransporte);
                cmd.Parameters.AddWithValue("@placaUnidTransporte", ut.placaUnidTransporte);
                cmd.Parameters.AddWithValue("@marca", ut.marca);
                cmd.Parameters.AddWithValue("@estUT", ut.estUT);
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

        // Método para deshabilitar una unidad de transporte
        public Boolean DeshabilitarUT(entUnidadTransporte ut)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaUT", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUnidadTransporte", ut.idUnidadTransporte);
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

        #endregion
    }
}
