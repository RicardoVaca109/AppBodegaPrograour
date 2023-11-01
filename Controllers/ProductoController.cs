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
        public IActionResult Details(int id)
        {
            return View();
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
        public IActionResult Edit(int id)
        {
            return View();
        }

       

        // GET: ProductoController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

       
        
    }
}
