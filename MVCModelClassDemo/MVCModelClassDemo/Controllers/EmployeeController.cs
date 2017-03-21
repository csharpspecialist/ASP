﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModelClassDemo.Models;

namespace MVCModelClassDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employees = from e in GetEmployeeList()
                          orderby e.Id
                          select e;
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [NonAction]

        public List<Employee> GetEmployeeList()
        {

            return new List<Employee>
                {
                        new Employee
                {
                    Id = 1, Name = "Barry Allen"
                    , JoinDate = DateTime.Parse(DateTime.Today.ToString())
                    , Age = 33
                },
                        new Employee
                { 
                          
                    Id = 2, Name = "Bruce Wayne"
                    , JoinDate = DateTime.Parse(DateTime.Today.ToString())
                    , Age = 44

                },

                    new Employee
                    {

                        Id = 3,
                        Name = "Peter Parker",
                        JoinDate = DateTime.Parse(DateTime.Today.ToString()),
                        Age = 20

                    },

                           new Employee
                    {

                        Id = 4,
                        Name = "Mary Jane",
                        JoinDate = DateTime.Parse(DateTime.Today.ToString()),
                        Age = 20

                    },
                };           

        }
    }
}





