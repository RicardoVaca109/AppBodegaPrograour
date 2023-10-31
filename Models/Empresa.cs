using System.ComponentModel.DataAnnotations;
namespace appBodega.Models
{
    public class Empresa
    {
        
        public int EmpresaID { get; set; }
        
        public string NombreEmpresa {  get; set; }
        
        public string Resumen { get; set; }

        public Empresa(int EmpresaID, string NombreEmpresa, string Resumen) { 
            this.EmpresaID = EmpresaID;
            this.NombreEmpresa = NombreEmpresa; 
            this.Resumen = Resumen;
        
        }
    }

   
}
