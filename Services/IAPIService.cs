using appBodega.Models;
namespace appBodega.Services
{
    public class IAPIService
    {
        Task<List<Producto>> GetProducto();
        Task<Producto> GetProducto(int ProveedorId);
        Task<Producto> PostProducto(Producto producto);
        Task<Producto> PutProducto(int ProductoId, Producto producto);
        Task<string> DeleteProducto(int ProductoId);

        Task<List<Empresa>> GetEmpresa();
        Task<Empresa> GetEmpresa(int EmpresaID);
        Task<Empresa> PostEmpresa(Empresa empresas);
        Task<Empresa> PutEmpresa(int EmpresaID, Empresa empresa);
        Task<Empresa> DeleteEmpresa(int EmpresaID);

        Task<List<User>> GetUser();
        Task<User> GetUser(int IdUser);
        Task<User> PostEmpresa(User userToValidate);
        Task<User> PostEmpresa(User newUser);

    }
}
