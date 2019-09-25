using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class JogadorController : Controller
    {

        private OlimpiadasContext _context;

        public JogadorController(OlimpiadasContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarSelectTimes();
            return View();
        }
        [HttpGet]
        private void CarregarSelectTimes()
        {
            var lista = _context.Times.ToList();
            ViewBag.Times = new SelectList(lista, "TimeId", "Nome");
        }

        [HttpPost]
        public IActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public IActionResult Buscar(Time time)
        {
            var Lista = _context.Jogadores.Where(t => t.Time == time ||
            time == null).ToList();
            return View("Listar", Lista);
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Jogadores.Include(t=>t.Time).ToList());
        }
    }
}