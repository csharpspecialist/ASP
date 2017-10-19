using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCPracByHand.Models;

namespace MVCPracByHand.Controllers
{
    public class TiresController : Controller
    {
        private TireDBContext db = new TireDBContext();

        // GET: Tires
        public ActionResult Index()
        {
            return View(db.Wheels.ToList());
        }

        // GET: Tires/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tire tire = db.Wheels.Find(id);
            if (tire == null)
            {
                return HttpNotFound();
            }
            return View(tire);
        }

        // GET: Tires/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tires/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TireWidth,Ratio,Diameter,Manufacturer,Location,Price,NumberInStock")] Tire tire)
        {
            if (ModelState.IsValid)
            {
                db.Wheels.Add(tire);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tire);
        }

        // GET: Tires/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tire tire = db.Wheels.Find(id);
            if (tire == null)
            {
                return HttpNotFound();
            }
            return View(tire);
        }

        // POST: Tires/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TireWidth,Ratio,Diameter,Manufacturer,Location,Price,NumberInStock")] Tire tire)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tire).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tire);
        }

        // GET: Tires/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tire tire = db.Wheels.Find(id);
            if (tire == null)
            {
                return HttpNotFound();
            }
            return View(tire);
        }

        // POST: Tires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tire tire = db.Wheels.Find(id);
            db.Wheels.Remove(tire);
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
