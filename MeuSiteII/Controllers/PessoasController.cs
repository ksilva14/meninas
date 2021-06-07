using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuSiteII.Data;
using MeuSiteII.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MeuSiteII.Controllers
{
    public class PessoasController : Controller{
        private readonly MeuSiteContext _context;

        public PessoasController(MeuSiteContext context){
            _context = context;
        }

        // GET: Pessoas
        public IActionResult Index(){
            List<Pessoa> pessoas = _context.Pessoas.ToList();
            return View(pessoas);
        }

        // GET: Pessoas/Details/5
        public IActionResult Details(int id){
            Pessoa pessoa = _context.Pessoas.Find(id);
            return View(pessoa); 
        }

        // GET: Pessoas/Create
        public IActionResult Create(){
            var sexoLista = new List<object>();
            sexoLista.Add(new { Codigo=Sexo.Masculino, Descricao="Masculino" });
            sexoLista.Add(new { Codigo=Sexo.Feminino, Descricao="Feminino" });

            ViewBag.Sexo = new SelectList(sexoLista, "Codigo", "Descricao");
            return View();
        }
        
        // POST: Pessoas/Create
        [HttpPost]
        public IActionResult Create(Pessoa pessoa){
            if (ModelState.IsValid){
                _context.Add(pessoa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public IActionResult Edit(int id){
            
// TRECHO COPIADO DE CREATE (para permitir editar o campo sexo) / NÃO EXISTE NO CÓDIGO ORIGINAL ----
            var sexoLista = new List<object>();
            sexoLista.Add(new { Codigo=Sexo.Masculino, Descricao="Masculino" });
            sexoLista.Add(new { Codigo=Sexo.Feminino, Descricao="Feminino" });
            ViewBag.Sexo = new SelectList(sexoLista, "Codigo", "Descricao");
//--------------------------------------------------------------------------------------------------
            Pessoa pessoa = _context.Pessoas.Find(id);
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Pessoa pessoa){
            if (ModelState.IsValid){
                _context.Update(pessoa);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public IActionResult Delete(int id){
            Pessoa pessoa = _context.Pessoas.Find(id);
            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id){
            Pessoa pessoa = _context.Pessoas.Find(id);
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool PessoaExists(int id){
            bool existe = _context.Pessoas.Any(x => x.PessoaId == id);
            return existe;
        }
    }

}