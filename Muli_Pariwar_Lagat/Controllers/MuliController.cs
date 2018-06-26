using Muli_Pariwar_Lagat.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Muli_Pariwar_Lagat.Controllers
{
    public class MuliController : Controller
    {
        private MyDbContext db = new MyDbContext();
        // GET: Muli
        public ActionResult Index()
        {
            return View(db.Mulis.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MuliViewModel Mul)
        {
            if (ModelState.IsValid)
            {
                db.Mulis.Add(new Muli
                {
                    GharNum = Mul.GharNum,
                    Woda = Mul.Woda,
                    sabik_G_B_S = Mul.sabik_G_B_S,
                    sabik_woda = Mul.sabik_woda,
                    tol = Mul.tol,
                    Naam = Mul.Naam,
                    Sikshhya = Mul.Sikshhya,
                    AddedDate = DateTime.Now,
                    Kaam = Mul.Kaam,
                    ContactNum = Mul.ContactNum,
                    JanmaMiti = Mul.JanmaMiti,
                    JanmaSthan = Mul.JanmaSthan,
                    NagarikId = Mul.NagarikId,
                    NagarikJariDate = Mul.NagarikJariDate,
                    NagarikJariJilla = Mul.NagarikJariJilla
                });
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Mul);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muli mul = db.Mulis.Find(id);
            if (mul == null)
            {
                return HttpNotFound();
            }
            return View(mul);
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GharNum,Woda,sabik_G_B_S,sabik_woda,tol,Naam,Sikshhya,AddedDate,Kaam,ContactNum,JanmaMiti,JanmaSthan,NagarikId,NagarikJariDate,NagarikJariJilla")] Muli mul)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mul).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mul);
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Muli mul = db.Mulis.Find(id);
            if (mul == null)
            {
                return HttpNotFound();
            }
            return View(mul);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Muli mul = db.Mulis.Find(id);
            db.Mulis.Remove(mul);
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