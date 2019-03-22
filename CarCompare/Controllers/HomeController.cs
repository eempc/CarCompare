using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarCompare.Models;


namespace CarCompare.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        // Three steps needed to add a new page: (1) this About() method, (2) the About.cshtml aka a 'Razor View' with layout (3) the anchor link in the_layout.cshtml file
        // But be aware that it is the cshtml page which calls this method here. Not this method calls the page.
        public IActionResult About() {
            return View();
        }

        public IActionResult Test()
        {
            
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
