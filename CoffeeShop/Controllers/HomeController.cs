using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CoffeeShop.Controllers
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
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignupLP(string firstname, string lastname, string favoritefood, string favoriteband, string favoritecoffee, string password, string cpassword)
        {
            Regex re = new Regex(@"^[a-zA-Z0-9]{5,100}\S\S$");
            if (re.IsMatch(password))
            {
                Console.WriteLine("This is Incorrect.\n");
            }
            ViewData["FirstName"] = firstname;
            ViewData["LastName"] = lastname;
            ViewData["FavoriteFood"] = favoritefood;
            ViewData["FavoriteBand"] = favoriteband;
            ViewData["FavoriteCoffee"] = favoritecoffee;
            return View();
        }

        public IActionResult LandingPage()
        {
            return View();
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
