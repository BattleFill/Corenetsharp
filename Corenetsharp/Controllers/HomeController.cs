using Corenetsharp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Corenetsharp.Controllers
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
            ViewData["1"] = "Оружие";
            ViewData["2"] = "Броня";
            ViewData["3"] = "Артефакты";
            ViewData["4"] = "Контейнеры";
            ViewData["5"] = "Другое";
            ViewData["11"] = "/images/weapons.png";
            ViewData["12"] = "/images/armor.png";
            ViewData["13"] = "/images/artifacts.png";
            ViewData["14"] = "/images/containers.png";
            ViewData["15"] = "/images/other.png";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Some()
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
