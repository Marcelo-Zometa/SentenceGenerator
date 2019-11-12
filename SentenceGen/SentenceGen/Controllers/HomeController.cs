using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SentenceGen.Models;

namespace SentenceGen.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult DisplayWord(FormModel model)
        {
            //This returns does not do anything

            //Send shrek to db
            var startingWord = model.Title_;

            //Wait for database response
            var dictionary = _contextCallDatabase;
            //Call IAction function and pass (Dictionary, startingword)
            return Content($"Hello {model.Title_}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
