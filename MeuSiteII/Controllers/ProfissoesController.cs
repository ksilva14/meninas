using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuSiteII.Data;
using MeuSiteII.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MeuSiteII.Controllers
{
    public class ProfissoesController : Controller{
        private readonly MeuSiteContext _context;

        public ProfissoesController(MeuSiteContext context){
            _context = context;
        }

        // GET: Profisoes
        public IActionResult Index(){
            List<Profissao> profissoes = _context.Profissoes.ToList();
            return View(profissoes);
        }

        // GET: Profissoes/Details/5
        public IActionResult Details(int id){
            Profissao profissao = _context.Profissoes.Find(id);
            return View(profissao); 
        }

        // GET: Profissoes/Create
        public IActionResult Create(){
            return View();
        }
        
        // POST: Profissoes/Create
        [HttpPost]
        public IActionResult Create(Profissao profissao){
            if (ModelState.IsValid){
                _context.Add(profissao);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(profissao);
        }

        // GET: Profissoes/Edit/5
        public IActionResult Edit(int id){
            Profissao profissao = _context.Profissoes.Find(id);
            return View(profissao);
        }

        // POST: Profissoes/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Profissao profissao){
            if (ModelState.IsValid){
                _context.Update(profissao);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(profissao);
        }

        // GET: Profissoes/Delete/5
        public IActionResult Delete(int id){
            Profissao profissao = _context.Profissoes.Find(id);
            return View(profissao);
        }

        // POST: Profissoes/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id){
            Profissao profissao = _context.Profissoes.Find(id);
            _context.Profissoes.Remove(profissao);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProfissaoExists(int id){
            bool existe = _context.Profissoes.Any(x => x.ProfissaoId == id);
            return existe;
        }
    }

}