using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class TimeController : Controller
    {
        private OlimpiadasContext _context;

        public TimeController(OlimpiadasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Time time)
        {
            _context.Times.Add(time);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Listar");
        }
     
        [HttpGet]
        public IActionResult Buscar(Esporte? esporte) // "?" significa que pode ser null
        {

            var Lista = _context.Times.Where(e => e.Esporte == esporte || 
            esporte == null).Include(c => c.Tecnico).ToList();
            return View("Listar", Lista);
        }


        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Times.Include(c => c.Tecnico).ToList()); //inclui o relacionamento, inclui o tecnico na lista
        }
    }
}