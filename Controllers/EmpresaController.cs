using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using appBodega.Utils;
using appBodega.Models;

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
        [HttpPost]
        public IActionResult Create(Empresa empresa)
        {
            int i = Utils.Utils.ListaEmpresas.Count() + 1;
            empresa.EmpresaID = i;
            Utils.Utils.ListaEmpresas.Add(empresa);
            return RedirectToAction("Index");
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
