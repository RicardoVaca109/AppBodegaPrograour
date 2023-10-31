using appBodega.Models;


namespace appBodega.Utils
{
    public class Utils
    {
        static public List<Empresa> ListaEmpresas = new List<Empresa>()
        {
            new Empresa(1,"Supermaxi","Tienda de Viveres"),
            new Empresa(2,"TecniEC","Electronica"),
            new Empresa(3,"Tuti","Tienda de Viveres"),
            new Empresa(4,"Newbie","ervicios de reparación")
        };
        static public List<Producto> ListaProductos = new List<Producto>() { 
            new Producto(1,"Procan","Comida para perros",54.99,45,1),
            new Producto(2,"Manicris","Mani",4.99,435,1),
            new Producto(3,"Contact Cleaner","Limpia Contactos",10.20,5,2),
            new Producto(4,"Pasta Térmica","Pasta para componentes",4.99,20,2)

        };
    }
}
