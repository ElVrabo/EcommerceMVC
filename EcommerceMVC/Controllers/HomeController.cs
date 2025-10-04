using System.Diagnostics;
using EcommerceMVC.DTOS;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
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
            var dto = new RegistryDto
            {
                Active = true,
                HighSystem = DateTime.Now,
            };
            return View(dto);
        }

        public IActionResult Privacy()
        {
            var dto = new CategoryReadDto
            {
                Id = 1,
                Name = "Electronica"
            };
            return View(dto);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
