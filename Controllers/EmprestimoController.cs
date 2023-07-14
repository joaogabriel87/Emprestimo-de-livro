using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Emprestimo_de_livro.Data;
using Emprestimo_de_livro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Emprestimo_de_livro.Controllers
{
 
    public class EmprestimoController : Controller
    {
       
       readonly private ApplicationDbContext _db;
        public EmprestimoController(ApplicationDbContext db)
        {
           _db = db; 
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimoModel> emprestimos = _db.Emprestimo;
            return View(emprestimos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(EmprestimoModel emprestimos)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimo.Add(emprestimos);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id )
        {
            if (id == null || id ==0)
            {
                return NotFound();
            }

            EmprestimoModel emprestimo = _db.Emprestimo.FirstOrDefault(x => x.Id == id);
             
              if (id == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Editar(EmprestimoModel emprestimo)
        {
            if (ModelState.IsValid)
            {
                _db.Emprestimo.Update(emprestimo);
                _db.SaveChanges();

                 TempData["MensagemSucesso"] = "Edição realizado com sucesso";
                return RedirectToAction("Index");
            }

            return View(emprestimo);
        }

        [HttpGet]
        public IActionResult Excluir (int? id )
        {
            if (id == null || id ==0)
            {
                return NotFound();
            }

            EmprestimoModel emprestimo = _db.Emprestimo.FirstOrDefault(x => x.Id == id);
             
              if (id == null)
            {
                return NotFound();
            }

            return View(emprestimo);
        }

        [HttpPost]
        public IActionResult Excluir(EmprestimoModel emprestimo)
        {
            if (emprestimo == null)
            {
                return NotFound();
            }

            _db.Emprestimo.Remove(emprestimo);
            _db.SaveChanges();
            TempData["MensagemSucesso"] = "Item excluido com sucesso";



            return RedirectToAction("Index");
        }

}
} 