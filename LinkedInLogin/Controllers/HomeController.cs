using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LinkedInLogin.Models;

namespace LinkedInLogin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var x = User;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //[Route("/login")]
        //public async Task Login()
        //{
        //    await HttpContext. .ChallengeAsync("LinkedIn", properties: new AuthenticationProperties() { RedirectUri = "/" });
        //}
    }
}
