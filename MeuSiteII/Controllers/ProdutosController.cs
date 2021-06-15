using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MeuSiteII.Data;
using MeuSiteII.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MeuSiteII.Controllers
{
    public class ProdutosController : Controller{
        private readonly MeuSiteContext _context;

        public ProdutosController(MeuSiteContext context){
            _context = context;
        }

        // GET: Produtos
        public IActionResult Index(){
            List<Produto> produtos = _context.Produtos.ToList();
            return View(produtos);
        }

        // GET: Produtos/Details/5
        public IActionResult Details(int id){
            Produto produto = _context.Produtos.Find(id);
            return View(produto); 
        }

        // GET: Produtos/Create
        public IActionResult Create(){
            return View();
        }
        
        // POST: Produtos/Create
        [HttpPost]
        public IActionResult Create(Produto produto){
            if (ModelState.IsValid){
                _context.Add(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public IActionResult Edit(int id){
            Produto produto = _context.Produtos.Find(id);
            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Produto produto){
            if (ModelState.IsValid){
                _context.Update(produto);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public IActionResult Delete(int id){
            Produto produto = _context.Produtos.Find(id);
            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id){
            Produto produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id){
            bool existe = _context.Produtos.Any(x => x.ProdutoId == id);
            return existe;
        }
    }

}