using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using appBodega.Models;
using System.Diagnostics;
using appBodega.Utils;


namespace appBodega.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public IActionResult Index()
        {

            return View(Utils.Utils.ListaProductos);
        }

        // GET: ProductoController/Details/5
        public IActionResult Details(int ProductoId)
        {
            Producto producto = Utils.Utils.ListaProductos.Find(x => x.ProductoId == ProductoId);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
            
        }

        // GET: ProductoController/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            int i = Utils.Utils.ListaProductos.Count() + 1;
            producto.ProductoId = i;
            Utils.Utils.ListaProductos.Add(producto);
            return RedirectToAction("Index");
        }


        // GET: ProductoController/Edit/5
        public IActionResult Edit(int ProductoId)
        {
            Producto producto = Utils.Utils.ListaProductos.Find(x => x.ProductoId == ProductoId);
            if (producto != null) {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            Producto producto2 = Utils.Utils.ListaProductos.Find(x => x.ProductoId == producto.ProductoId);
            if (producto2 != null)
            {
                producto2.Nombre = producto.Nombre;
                producto2.Descripcion = producto.Descripcion;
                producto2.Precio = producto.Precio;
                producto2.CtdenStock = producto.CtdenStock;
                producto2.ProveedorId = producto.ProveedorId;
                return RedirectToAction("Index");

            }
            return View();
        }



        // GET: ProductoController/Delete/5
        public IActionResult Delete(int ProductoId)
        {
            Producto producto2 = Utils.Utils.ListaProductos.Find(x => x.ProductoId == ProductoId);
            if (producto2 != null)
            { 
                Utils.Utils.ListaProductos.Remove(producto2);
                return RedirectToAction("Index");
            }
                return RedirectToAction("Index");
        }

       
        
    }
}
