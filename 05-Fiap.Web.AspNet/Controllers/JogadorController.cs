using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class JogadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}