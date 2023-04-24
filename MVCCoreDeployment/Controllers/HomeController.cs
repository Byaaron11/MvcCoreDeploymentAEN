using Microsoft.AspNetCore.Mvc;
using MVCCoreDeployment.Models;
using System.Diagnostics;

namespace MVCCoreDeployment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["MENSAJE"] = "Bienvenido a los lunes";
            Random rnd = new Random();
            List<int> numeros = new List<int>();
            for (int i = 0; i<= 10; i++)
            {
                int num = rnd.Next(1, 100);
                numeros.Add(num);
            }

            return View(numeros);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}