﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Treehouse.FitnessFrog.Data;
using Treehouse.FitnessFrog.Models;

namespace Treehouse.FitnessFrog.Controllers
{
    public class EntriesController : Controller
    {
        private EntriesRepository _entriesRepository = null;

        public EntriesController()
        {
            _entriesRepository = new EntriesRepository();
        }

        public ActionResult Index()
        {
            List<Entry> entries = _entriesRepository.GetEntries();

            // Calculate the total activity.
            double totalActivity = entries
                .Where(e => e.Exclude == false)
                .Sum(e => e.Duration);

            // Determine the number of days that have entries.
            int numberOfActiveDays = entries
                .Select(e => e.Date)
                .Distinct()
                .Count();

            ViewBag.TotalActivity = totalActivity;
            ViewBag.AverageDailyActivity = (totalActivity / (double)numberOfActiveDays);

            return View(entries);
        }

        public ActionResult Add()
        {
            var entry = new Entry()
            {
                Date = DateTime.Today                        
                                
            };

            ActivitiesSelectListItem();

            return View(entry);
        }

        [ HttpPost]
        public ActionResult Add(Entry entry)
        {
            //if no Duration Field val errors.. make sure 
            //that the duration is greater than zero
            ValidateEntry(entry);

            if (ModelState.IsValid)
            {

                _entriesRepository.AddEntry(entry);

                return RedirectToAction("Index");

            }

            ActivitiesSelectListItem();
               
            return View(entry);
        }            
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Entry entry = _entriesRepository.GetEntry((int)id);

            if(entry == null)
            {
                return HttpNotFound();
            }
            ActivitiesSelectListItem();

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Entry entry)
        {

            ValidateEntry(entry);
            //TODO validate the entry

        if (ModelState.IsValid)
            {
                _entriesRepository.UpdateEntry(entry);

                return RedirectToAction("Index");
            }

            ActivitiesSelectListItem();
            return View(entry);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TODO RETRIEVE entry for the provided param val

            Entry entry = _entriesRepository.GetEntry((int)id);
            //TODO return not found if entry not found
            if (entry == null)
            {
                return HttpNotFound();
            }
            //TODO pass the entry to the view
            return View(entry);
        }

        [HttpPost]

        public ActionResult Delete(int id)
        {            
            _entriesRepository.DeleteEntry(id);
           
            return RedirectToAction("Index");
        }
        

        private void ValidateEntry(Entry entry)
        {
            if (ModelState.IsValidField("Duration") && entry.Duration <= 0)
            {
                ModelState.AddModelError(("Duration"), "The duration value must be greater than 0");
            }
        }

        private void ActivitiesSelectListItem()
        {
            ViewBag.ActivitiesSelectListItems = new SelectList(
                Data.Data.Activities, "ID", "Name");
        }

    }
}