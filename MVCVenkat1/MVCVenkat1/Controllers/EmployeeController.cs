using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCVenkat1.Models;

namespace MVCVenkat1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee worker = new Employee()
            {
                EmployeeId = 2,
                Name = "Jaques",
                Gender = "Male",
                City = "Aqua"

            }; 

       
            //if you don't pass the worker object 
            //below you will get a null reference
            //exception...your code blows up!!!!
            return View(worker);
        }
    }
}