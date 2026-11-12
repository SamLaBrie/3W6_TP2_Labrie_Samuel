using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NutriVie.Models;
using NutriVie.Models.Data;

namespace NutriVie.Controllers
{
    public class HomeController : Controller
    {
        public NutriVieDbContext _baseDonnees { get; set; }
        public HomeController(NutriVieDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }
        public IActionResult Index()
        {
            List<Service> servicesList = _baseDonnees.Services.ToList();
            return View(servicesList);
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
