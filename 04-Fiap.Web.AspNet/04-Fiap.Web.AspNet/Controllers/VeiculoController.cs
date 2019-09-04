using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Fiap.Web.AspNet.Models;
using _04_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.AspNet.Controllers
{
    public class VeiculoController : Controller
    {
        private LocadoraContext _context;

        public VeiculoController(LocadoraContext context)
        {
            _context = context;
        }

        //Editando
        [HttpPost]
        public IActionResult Editar(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
            TempData["msg"] = "Atualizado!";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            _context.Veiculos.Remove(_context.Veiculos.Find(id)); // irei remover o que encontrarei no find 
            _context.SaveChanges();
            TempData["msg"] = "Excluído!";
            return RedirectToAction("Listar");
        }

        //Editando Get
        [HttpGet]
        public IActionResult Editar(int id) // Aqui tem que ser id igual o route-id
        {
            var veiculo = _context.Veiculos.Find(id);
            return View(veiculo);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Veiculos.ToList());
        }

        [HttpPost]
        public IActionResult Cadastrar(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}