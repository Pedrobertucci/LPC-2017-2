using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula06_exercicios_oo.Models;

namespace Aula06_exercicios_oo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // Cliente leo = new Cliente(1,"Leonardo");
            
            // return "Código: " + leo.id +
            //        "Nome: " + leo.nome;
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
    }
}
