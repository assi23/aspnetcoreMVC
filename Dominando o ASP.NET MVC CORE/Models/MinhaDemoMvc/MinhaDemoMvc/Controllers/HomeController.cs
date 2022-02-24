using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaDemoMvc.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace MinhaDemoMvc.Controllers
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
            //var filme = new Filme
            //{
            //    Titulo = "oi",
            //    DataLancamento = System.DateTime.Now,
            //    Genero = null,
            //    Avaliacao = 10,
            //    Valor = 20000
            //};
            //return RedirectToAction("Privacy",filme);
            return View();
        }

        public IActionResult Privacy(Filme filme )
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(x=> x.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
