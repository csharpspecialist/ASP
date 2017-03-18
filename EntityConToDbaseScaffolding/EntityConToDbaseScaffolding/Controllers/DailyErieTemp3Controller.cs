using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityConToDbaseScaffolding.Models;

namespace EntityConToDbaseScaffolding.Controllers
{
    public class DailyErieTemp3Controller : Controller
    {
        private ShieldEntities3 db = new ShieldEntities3();

        // GET: DailyErieTemp3
        public ActionResult Index()
        {
            return View(db.DailyErieTemp3.ToList());
        }

        // GET: DailyErieTemp3/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyErieTemp3 dailyErieTemp3 = db.DailyErieTemp3.Find(id);
            if (dailyErieTemp3 == null)
            {
                return HttpNotFound();
            }
            return View(dailyErieTemp3);
        }

        // GET: DailyErieTemp3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DailyErieTemp3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TempID,Year,Month,Day,Temp")] DailyErieTemp3 dailyErieTemp3)
        {
            if (ModelState.IsValid)
            {
                db.DailyErieTemp3.Add(dailyErieTemp3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dailyErieTemp3);
        }

        // GET: DailyErieTemp3/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyErieTemp3 dailyErieTemp3 = db.DailyErieTemp3.Find(id);
            if (dailyErieTemp3 == null)
            {
                return HttpNotFound();
            }
            return View(dailyErieTemp3);
        }

        // POST: DailyErieTemp3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TempID,Year,Month,Day,Temp")] DailyErieTemp3 dailyErieTemp3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dailyErieTemp3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dailyErieTemp3);
        }

        // GET: DailyErieTemp3/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DailyErieTemp3 dailyErieTemp3 = db.DailyErieTemp3.Find(id);
            if (dailyErieTemp3 == null)
            {
                return HttpNotFound();
            }
            return View(dailyErieTemp3);
        }

        // POST: DailyErieTemp3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DailyErieTemp3 dailyErieTemp3 = db.DailyErieTemp3.Find(id);
            db.DailyErieTemp3.Remove(dailyErieTemp3);
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
