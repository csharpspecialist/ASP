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


        public ActionResult EmpIndex(int departmentID)
        {
            EmployeeContext emp = new EmployeeContext();
            List<Employee> employ = emp.Employees.Where(empl => empl.DepartmentID == departmentID).ToList();

            return View(employ);
        }



        // GET: Employee
        public ActionResult Details(int? id)
        {
     EmployeeContext employeeContext = new EmployeeContext();

            //Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            Employee employ = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
       
            //if you don't pass the worker object 
            //below you will get a null reference
            //exception...your code blows up!!!!
            return View(employ);
        }

        public ActionResult EmpList()
        {

            EmployeeContext emp = new EmployeeContext();
            List<Employee> employ = emp.Employees.ToList();

            return View(employ);
        }



    }
}