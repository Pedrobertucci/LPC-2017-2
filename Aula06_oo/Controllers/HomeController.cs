using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Aula06_oo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula06_oo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
               
            Paciente joazinho =
                 new Paciente("João da silva", 
                               10,123456);
            
            
            return  joazinho.nome + 
                    " tem " + 
                    joazinho.idade +
                     " anos.";
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
