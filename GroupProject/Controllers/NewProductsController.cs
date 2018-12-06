using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GroupProject.Models;

namespace GroupProject.Controllers
{
    public class NewProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: NewProducts
        public ActionResult Index()
        {
            return View(db.newProduct.ToList());
        }

        // GET: NewProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewProduct newProduct = db.newProduct.Find(id);
            if (newProduct == null)
            {
                return HttpNotFound();
            }
            return View(newProduct);
        }

        // GET: NewProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "newID,newProdName,newProdDescription,newProdPrice,newProdPicture")] NewProduct newProduct)
        {
            if (ModelState.IsValid)
            {
                db.newProduct.Add(newProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newProduct);
        }

        // GET: NewProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewProduct newProduct = db.newProduct.Find(id);
            if (newProduct == null)
            {
                return HttpNotFound();
            }
            return View(newProduct);
        }

        // POST: NewProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "newID,newProdName,newProdDescription,newProdPrice,newProdPicture")] NewProduct newProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newProduct);
        }

        // GET: NewProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewProduct newProduct = db.newProduct.Find(id);
            if (newProduct == null)
            {
                return HttpNotFound();
            }
            return View(newProduct);
        }

        // POST: NewProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewProduct newProduct = db.newProduct.Find(id);
            db.newProduct.Remove(newProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
