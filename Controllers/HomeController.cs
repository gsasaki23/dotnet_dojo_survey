using System;
using dojo_survey.Models;
using Microsoft.AspNetCore.Mvc;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            // looks for Views/Home/Index.cshtml
            return View("Index");
        }

        [HttpPost("/result")]
        public ViewResult Result(User newUser)
        {
            return View("Result",newUser);
        }

        // All other paths redirect to index
        [HttpGet("{Path}")]
        public RedirectToActionResult Unknown(string path)
        {
            Console.WriteLine(path);
            return RedirectToAction("/");
        }
    }
}