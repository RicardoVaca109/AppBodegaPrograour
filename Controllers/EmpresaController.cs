using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using appBodega.Utils;

namespace appBodega.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: EmpresaController
        public IActionResult Index()
        {
            
            return View(Utils.Utils.ListaEmpresas);
        }

        // GET: EmpresaController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpresaController/Create
        public IActionResult Create()
        {
            return View();
        }

        

        // GET: EmpresaController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

       

        // GET: EmpresaController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        
    }
}
