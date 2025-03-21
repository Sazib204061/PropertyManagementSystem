using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjectManagementSystem.Application.Cities;
using PropertyManagementSystem.Web.Models;

namespace PropertyManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICityService _cityService;

        public HomeController(ICityService cityService,ILogger<HomeController> logger)
        {
            _cityService = cityService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            var cities = await _cityService.GetAllCitiesAsync();

            return View(cities);
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
