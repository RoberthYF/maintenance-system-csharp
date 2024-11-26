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
    public class datRequerimientoMateriales
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly datRequerimientoMateriales _instancia = new datRequerimientoMateriales();

        // Propiedad para acceder a la instancia única
        public static datRequerimientoMateriales Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entRequerimientoMateriales> ListarRequerimientoMateriales()
        {
            SqlCommand cmd = null;
            List<entRequerimientoMateriales> lista = new List<entRequerimientoMateriales>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPedidoMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRequerimientoMateriales rm = new entRequerimientoMateriales();
                    rm.Operario = new entOperario();
                    rm.Material = new entMaterial();
                    rm.Id = Convert.ToInt32(dr["Id"]);
                    rm.FechaRequerimiento = dr.GetDateTime(dr.GetOrdinal("FechaRequerimiento"));
                    rm.Operario.Nombre = dr["NombreOperario"].ToString(); 
                    rm.Material.Nombre = dr["NombreMaterial"].ToString(); 
                    rm.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    rm.FechaIngreso = dr["FechaIngreso"] != DBNull.Value ? (DateTime?)dr["FechaIngreso"] : null;
                    rm.IdEstado = Convert.ToInt32(dr["IdEstado"]);

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

        public bool InsertarRequerimientoMateriales(entRequerimientoMateriales rm)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarRequerimientoMaterial", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOperario", rm.Operario.Id);
                cmd.Parameters.AddWithValue("@IdMaterial", rm.Material.Id);
                cmd.Parameters.AddWithValue("@Cantidad", rm.Cantidad);
                cmd.Parameters.AddWithValue("@IdEstado", rm.IdEstado);
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
