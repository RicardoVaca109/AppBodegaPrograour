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
        public IActionResult Edit(int EmpresaID)
        {   
            Empresa empresa = Utils.Utils.ListaEmpresas.Find(x => x.EmpresaID == EmpresaID);
            if (empresa != null)
            {
                return View(empresa);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Empresa empresa)
        {
           Empresa empresa2 = Utils.Utils.ListaEmpresas.Find(x=> x.EmpresaID == empresa.EmpresaID);
           if (empresa2 != null)
            {
                empresa2.NombreEmpresa = empresa.NombreEmpresa;
                empresa2.Resumen = empresa.Resumen;
                return RedirectToAction("Index");
            }
            return View();
        }


        // GET: EmpresaController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        
    }
}
