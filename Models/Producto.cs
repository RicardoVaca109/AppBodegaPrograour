using System.ComponentModel.DataAnnotations;

namespace appBodega.Models
{
    public class Producto
    {
        
        public int ProductoId { get; set; }
        
        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        
        public double Precio { get; set; }
        
        public int CtdenStock { get; set; }
        
        public int ProveedorId { get; set; }

        public Producto(int ProductoId, string Nombre, string Descripcion, double Precio, int CtdenStock,int ProveedorId)
        {
            this.ProductoId = ProductoId;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;  
            this.CtdenStock = CtdenStock;
            this.ProveedorId = ProveedorId;
        }
    }
}
