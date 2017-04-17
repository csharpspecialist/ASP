using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DinnerForNerds.Models;

namespace DinnerForNerds.Controllers
{
    public class HomeController : Controller
    {
        NerdDinners nerdDinners = new NerdDinners();

        // GET: Home
        public ActionResult Index()
        {
            var dinners = from d in nerdDinners.Dinners
                          where d.EventDate > DateTime.Now
                          select d;



            return View(nerdDinners.Dinners.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dinner dinner = nerdDinners.Dinners.Find(id);
            if (dinner == null)
            {
                return HttpNotFound();
            }
            return View(dinner);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DinnerID,Title,EventDate,Address,HostedBy")] Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                nerdDinners.Dinners.Add(dinner);
                nerdDinners.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dinner);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dinner dinner = nerdDinners.Dinners.Find(id);
            if (dinner == null)
            {
                return HttpNotFound();
            }
            return View(dinner);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DinnerID,Title,EventDate,Address,HostedBy")] Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                nerdDinners.Entry(dinner).State = EntityState.Modified;
                nerdDinners.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dinner);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dinner dinner = nerdDinners.Dinners.Find(id);
            if (dinner == null)
            {
                return HttpNotFound();
            }
            return View(dinner);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dinner dinner = nerdDinners.Dinners.Find(id);
            nerdDinners.Dinners.Remove(dinner);
            nerdDinners.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                nerdDinners.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
