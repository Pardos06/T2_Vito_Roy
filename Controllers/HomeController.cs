using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using T2_Vito_Roy.Models;

namespace T2_Vito_Roy.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Pagina1()
        {
            return View(); 
        }

        public IActionResult Pagina2()
        {
            return View();
        }

        public IActionResult Pagina3()
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
