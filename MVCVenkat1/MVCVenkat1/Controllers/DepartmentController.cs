using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCVenkat1.Models;

namespace MVCVenkat1.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult DepIndex()
        {
            EmployeeContext employ = new EmployeeContext();

            List<Department> departments = employ.Departments.ToList();
            return View(departments);
        }
    }
}