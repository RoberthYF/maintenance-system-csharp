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
    public class datProveedor
    {
        #region Singleton
        // Implementación del patrón Singleton
        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia
        {
            get { return datProveedor._instancia; }
        }
        #endregion Singleton

        #region Métodos

        // Listar Proveedores
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor prov = new entProveedor();
                    prov.idProveedor = Convert.ToInt32(dr["idProveedor"]);
                    prov.nombreProveedor = dr["nombreProveedor"].ToString();
                    prov.RUC = dr["RUC"].ToString();
                    prov.direccion = dr["direccion"].ToString();
                    prov.rubro = dr["rubro"].ToString();
                    prov.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    prov.estProveedor = Convert.ToBoolean(dr["estProveedor"]);

                    lista.Add(prov);
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

        // Insertar Proveedor
        public bool InsertarProveedor(entProveedor prov)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreProveedor", prov.nombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", prov.RUC);
                cmd.Parameters.AddWithValue("@direccion", prov.direccion);
                cmd.Parameters.AddWithValue("@rubro", prov.rubro);
                cmd.Parameters.AddWithValue("@idCiudad", prov.idCiudad);
                cmd.Parameters.AddWithValue("@estProveedor", prov.estProveedor);
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

        // Editar Proveedor
        public bool EditarProveedor(entProveedor prov)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", prov.idProveedor);
                cmd.Parameters.AddWithValue("@nombreProveedor", prov.nombreProveedor);
                cmd.Parameters.AddWithValue("@RUC", prov.RUC);
                cmd.Parameters.AddWithValue("@direccion", prov.direccion);
                cmd.Parameters.AddWithValue("@rubro", prov.rubro);
                cmd.Parameters.AddWithValue("@idCiudad", prov.idCiudad);
                cmd.Parameters.AddWithValue("@estProveedor", prov.estProveedor);
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

        // Deshabilitar Proveedor
        public bool DeshabilitarProveedor(entProveedor prov)
        {
            SqlCommand cmd = null;
            bool deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", prov.idProveedor);
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

        #endregion Métodos
    }
}
