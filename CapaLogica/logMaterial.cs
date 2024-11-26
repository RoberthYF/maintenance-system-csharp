using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMaterial
    {
        #region Singleton
        // Patrón Singleton
        // Variable estática para la instancia
        private static readonly logMaterial _instancia = new logMaterial();

        // Propiedad para acceder a la instancia única
        public static logMaterial Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion

        public List<entMaterial> ListarMaterial()
        { 
           return datMaterial.Instancia.ListarMaterial();
        
        }

        public void RegistrarMaterial(entMaterial ma)
        {
            datMaterial.Instancia.RegistrarMaterial(ma);
        
        }
        public bool EditarMaterial(entMaterial ma) 
        { 
        
           return  datMaterial.Instancia.EditarMaterial(ma);
        }
        public bool DeshabilitarMaterial(entMaterial ma)
        {
           return datMaterial.Instancia.DeshabilitarMaterial(ma);
        }
    }
}
