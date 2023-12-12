using appBodega.Models;
using appBodega.Services;
using Microsoft.AspNetCore.Mvc;

namespace appBodega.Controllers
{
    public class UserController : Controller
    {
        private readonly IAPIService _apiService;

        public UserController(IAPIService apiService)
        {
            _apiService = apiService;
        }
        // GET: UserController
        public async Task<IActionResult> Index()
        {
            List<User> usuarios = await _apiService.GetUsers();
            return View(usuarios);
        }

        // GET: UserController/Details/5
        public async Task<IActionResult> Details(User usuario)
        {
            try
            {
                var result = await _apiService.VerificarUsuario(usuario);

                if (result)
                {
                    return RedirectToAction("Index", "Producto");
                }
                else
                {
                    TempData["Error"] = "Credenciales incorrectas. Por favor, inténtelo de nuevo.";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la verificación.
                TempData["Error"] = "Ocurrió un error durante la verificación. Por favor, inténtelo de nuevo.";
                return RedirectToAction("Index");
            }
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User usuario)
        {
            User usuario1 = await _apiService.PostUser(usuario);
            return RedirectToAction("Index");
        }

        // GET: UserController/Edit/5
        public async Task<IActionResult> Edit(int IdUser)
        {
            User usuarios = await _apiService.GetUser(IdUser);
            if (usuarios != null)
            {
                return View(usuarios);
            }
            return RedirectToAction("Index");
        }

      
    }
}
