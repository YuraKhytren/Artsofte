using ArtSoftUi.Models;
using ArtSoftUi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArtSoftUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService _service;

        public HomeController(ILogger<HomeController> logger, IService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<UserModel> list = await _service.GetAllUsersAsync();


            return View(list);
        }

    }
}