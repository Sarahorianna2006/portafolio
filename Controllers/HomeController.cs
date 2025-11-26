using Microsoft.AspNetCore.Mvc;
using MiPortafolioMVC.Services;

namespace portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectService _service;

        public HomeController(ProjectService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var projects = _service.GetProjects();
            return View(projects);
        }
        
        [HttpPost]
        public IActionResult EnviarMensaje(string nombre, string email, string mensaje)
        {
            // Aquí puedes enviarlo a correo, guardar en DB, etc.
    
            Console.WriteLine("Nuevo mensaje:");
            Console.WriteLine(nombre);
            Console.WriteLine(email);
            Console.WriteLine(mensaje);

            TempData["MensajeEnviado"] = "Tu mensaje fue enviado correctamente";

            return RedirectToAction("Index");
        }

    }
}