using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04_Fiap.Web.AspNet.Models;
using _04_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace _04_Fiap.Web.AspNet.Controllers
{
    public class ProprietarioController : Controller
    {
        private LocadoraContext _context;

        public ProprietarioController(LocadoraContext context)
        {

            _context = context;
        }
        //add-migration [nome qualquer] 
        //update-database
        //Cadastrar
        [HttpPost]
        public IActionResult Cadastrar(Proprietario proprietario)
        {
            _context.Proprietario.Add(proprietario); // adicionando à lista
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        //Atualizar com post   
        [HttpPost]
        public IActionResult Editar(Proprietario proprietario)
        {
            _context.Proprietario.Update(proprietario);
            _context.SaveChanges();
            TempData["msg"] = "Editado!";
            return RedirectToAction("Listar");
        }

        //Atualizar com Get
        [HttpGet]
        public IActionResult Editar(int id)
        {
            var proprietario = _context.Proprietario.Find(id);
            return View(proprietario);
        }

        //Listar
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Proprietario.ToList());
        }

        //Excluir
        [HttpPost]
        public IActionResult Excluir(int id)
        {
            _context.Proprietario.Remove(_context.Proprietario.Find(id));
            _context.SaveChanges();
            TempData["msg"] = "Excluído!";
            return RedirectToAction("Listar");
        }
    }
}