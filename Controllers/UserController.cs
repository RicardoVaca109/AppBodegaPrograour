using appBodega.Models;
using appBodega.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

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
        /*[HttpPost]
        public async Task<IActionResult> CreateUser(User usuario)
        {
            User newUser = await _apiService.PostUser(usuario);
            return RedirectToAction("Index");
        }*/
        [HttpPost]
        public async Task<IActionResult> CrearUsuario(User usuario)
        {
            // Validar el modelo y otros procesos de lógica de negocio si es necesario

            // Crear un nuevo objeto User con los datos del modelo
            var newUser = new User
            {
                UserMail = usuario.UserMail,
                UserPassword = usuario.UserPassword,
                
            };

            // Llamar al método PostUser para crear el usuario
            var createdUser = await _apiService.PostUser(newUser);

            if (createdUser != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // Manejar el caso de error (mostrar un mensaje de error en la vista)
                ModelState.AddModelError(string.Empty, "Error al crear el usuario.");
                return View(usuario);
            }
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
