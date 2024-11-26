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
    public class datOperario
    {
        #region Singleton
        // Implementación del patrón Singleton
        private static readonly datOperario _instancia = new datOperario();
        public static datOperario Instancia
        {
            get { return datOperario._instancia; }
        }
        #endregion Singleton

        #region Métodos

        // Listar Operarios
        public List<entOperario> ListarOperario()
        {
            SqlCommand cmd = null;
            List<entOperario> lista = new List<entOperario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarOperario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOperario op = new entOperario();
                    op.Id = Convert.ToInt32(dr["Id"]);
                    op.Nombre = dr["Nombre"].ToString();
                    op.Apellido = dr["Apellido"].ToString();
                    op.Dni = dr["Dni"].ToString();
                    op.Edad = Convert.ToInt32(dr["Edad"]);
                    op.Genero = dr["Genero"].ToString();
                    op.Estado = Convert.ToBoolean(dr["Estado"]);

                    lista.Add(op);
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

        // Insertar Operario
        public bool InsertarOperario(entOperario op)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOperario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nombre", op.Nombre);
                cmd.Parameters.AddWithValue("Apellido", op.Apellido);
                cmd.Parameters.AddWithValue("Dni", op.Dni);
                cmd.Parameters.AddWithValue("Edad", op.Edad);
                cmd.Parameters.AddWithValue("Genero", op.Genero);
                cmd.Parameters.AddWithValue("Estado", op.Estado);

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

        // Editar Operario
        public bool EditarOperario(entOperario op)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarOperario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", op.Id);
                cmd.Parameters.AddWithValue("Nombre", op.Nombre);
                cmd.Parameters.AddWithValue("Apellido", op.Apellido);
                cmd.Parameters.AddWithValue("Dni", op.Dni);
                cmd.Parameters.AddWithValue("Edad", op.Edad);
                cmd.Parameters.AddWithValue("Genero", op.Genero);
                cmd.Parameters.AddWithValue("Estado", op.Estado);
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

        // Deshabilitar Operario
        public bool DeshabilitarOperario(entOperario op)
        {
            SqlCommand cmd = null;
            bool deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarOperario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", op.Id);
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
        public List<entOperario> ListarOperarioCBX()
        {
            SqlCommand cmd = null;
            List<entOperario> lista = new List<entOperario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ListarOperarioCBX", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entOperario op = new entOperario();
                    op.Id = Convert.ToInt32(dr["id"]);
                    op.Nombre = dr["Nombre"].ToString();
                    op.Apellido = dr["Apellido"].ToString();
                    lista.Add(op);
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
        #endregion Métodos
    }
}
