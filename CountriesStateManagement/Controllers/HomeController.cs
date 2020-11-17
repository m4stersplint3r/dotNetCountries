using CountriesStateManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesStateManagement.Controllers
{
    public class HomeController : Controller
    {
        List<Country> countries = new List<Country>{
            new Country("USA", "English", "Hello World", "The land of the free", new List<string> { "red", "white", "blue" }),
            new Country("Mexico", "Espanol", "Hola amigo.", "This is Mexico", new List<string> { "green", "white", "red" }),
            new Country("Japan", "Japanese", "Kon'nichiwa tomodachi.", "All about Japan", new List<string> { "red", "white"}),
            };

        public IActionResult Index()
        {
            return View(countries);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CountryDetails(int index)
        {
            Country country = countries[index];
            return View(country);
        }

        public IActionResult CountryDescription()
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
