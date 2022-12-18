using ArtSoftUi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArtSoftUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(new UserModel() { Id = 1, Name = "name", Surname = "Surneme", Age = 100, Department = 2 , ProgrammingLenguage = "C#"});
        }

    }
}