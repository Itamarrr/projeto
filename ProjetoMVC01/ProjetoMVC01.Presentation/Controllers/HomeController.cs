using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoMVC01.Presentation.Controllers
{
    //definição da classe
    public class HomeController : Controller
    {
        //método para gerar/abrir uma página /Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
