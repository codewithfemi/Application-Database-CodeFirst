using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IDE.Models;
using IDE.Data;

namespace IDE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebContext _webContext;

        public HomeController(ILogger<HomeController> logger, WebContext webContext)
        {
            _logger = logger;
            _webContext = webContext;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.People = _webContext.Person.ToList();
            model.Title = "Welcome Youtube Viewers";
            model.Description = "I Love you guys";
            return View(model);
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
