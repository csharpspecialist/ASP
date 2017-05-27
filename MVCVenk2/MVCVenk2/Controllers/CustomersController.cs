using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using System.Data;
namespace MVCVenk2.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ActionResult Index()
        {

            CustomerBLL cbl = new CustomerBLL();

            List<Customers> custs = cbl.xCustomers.ToList();  

            return View(custs);
        }
        [HttpGet]
        public ActionResult Create()
        {            
            return View();

        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            Customers cust = new Customers();

            cust.Fname = formCollection["Fname"];
            cust.Gender = formCollection["Gender"];
            cust.Salary = formCollection["Salary"];
            cust.City= formCollection["City"];

            CustomerBLL cbl = new CustomerBLL();
            cbl.AddCustomer(cust);

            return RedirectToAction("Index"); 

        }


    }
}