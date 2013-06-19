using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WERP.Models;

namespace WERP.Controllers
{
    public class ProdutosController : Controller
    {
        private WERPContext db = new WERPContext();

        //
        // GET: /Produtos/

        public ActionResult Index()
        {
            return View(db.ProdutoModels.ToList());
        }

        public JsonResult IndexJson()
        {
            return Json(db.ProdutoModels.ToList(), JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Produtos/Details/5

        public ActionResult Details(int id = 0)
        {
            ProdutoModel produtomodel = db.ProdutoModels.Find(id);
            if (produtomodel == null)
            {
                return HttpNotFound();
            }
            return View(produtomodel);
        }

        //
        // GET: /Produtos/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Produtos/Create

        [HttpPost]
        public ActionResult Create(ProdutoModel produtomodel)
        {
            if (ModelState.IsValid)
            {
                db.ProdutoModels.Add(produtomodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(produtomodel);
        }

        //
        // GET: /Produtos/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ProdutoModel produtomodel = db.ProdutoModels.Find(id);
            if (produtomodel == null)
            {
                return HttpNotFound();
            }
            return View(produtomodel);
        }

        //
        // POST: /Produtos/Edit/5

        [HttpPost]
        public ActionResult Edit(ProdutoModel produtomodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produtomodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produtomodel);
        }

        //
        // GET: /Produtos/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ProdutoModel produtomodel = db.ProdutoModels.Find(id);
            if (produtomodel == null)
            {
                return HttpNotFound();
            }
            return View(produtomodel);
        }

        //
        // POST: /Produtos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ProdutoModel produtomodel = db.ProdutoModels.Find(id);
            db.ProdutoModels.Remove(produtomodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}