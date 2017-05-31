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
        [ActionName("Create")] //this was added/explained in session 11 about 6 mins in
        public ActionResult Create_Get()
        {            
            return View();

        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            Customers customer = customerBLL.xCustomers.Single(custom => custom.CustomerID == id);

            return View(customer);

        }


        [HttpPost]
        //[ActionName("Edit")]
        public ActionResult Edit_Get(Customers customer)
        {
            if(ModelState.IsValid)
            { 
            CustomerBLL customerBLL = new CustomerBLL();
                customerBLL.SaveCustomers(customer);

                return RedirectToAction("Index");
            }

            return View(customer);

        }


        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            Customers customer = customerBLL.xCustomers.Single(x => x.CustomerID == id);
            UpdateModel(customer, new string[] { "CustomerID", "Fname", "Salary", "City", "PaymentType" });

            if (ModelState.IsValid)
            {
              
                customerBLL.SaveCustomers(customer);

                return RedirectToAction("Index");
            }

            return View(customer);

        }



        // method # 1 below...this will work also..it just uses formcollection 
        //to pass the types from the form on the create page to the database

        //[HttpPost] 
        //public ActionResult Create(FormCollection formCollection)
        //{
        //    Customers cust = new Customers();

        //    cust.Fname = formCollection["Fname"];
        //    cust.Gender = formCollection["Gender"];
        //    cust.Salary = formCollection["Salary"];
        //    cust.City= formCollection["City"];
        //    cust.PaymentType = formCollection["PaymentType"];

        //    CustomerBLL cbl = new CustomerBLL();
        //    cbl.AddCustomer(cust);

        //    return RedirectToAction("Index"); 

        //}

        //[HttpPost]  //  method # 2...this works also
        //public ActionResult Create(string fname, string gender, string salary, string city, string paymentType)
        //{
        //    Customers cust = new Customers();

        //    cust.Fname = fname;
        //    cust.Gender = gender;
        //    cust.Salary = salary;
        //    cust.City = city;
        //    cust.PaymentType = paymentType;

        //    CustomerBLL cbl = new CustomerBLL();
        //    cbl.AddCustomer(cust);

        //    return RedirectToAction("Index");

        //}

        //method # 3...the parameter MUST BE  Customer customer
        //for this to work as customer is used in the AddCustomer 
        //method in the BLL

        //[HttpPost]
        //public ActionResult Create(Customers customer)
        //{

        //    if (ModelState.IsValid)
        //    {


        //        CustomerBLL cbl = new CustomerBLL();
        //        cbl.AddCustomer(customer);

        //        return RedirectToAction("Index");
        //    }

        //    return View();
        //}

        //if get error about specified count to semiphore ...restart IIS
        [HttpPost]
        [ActionName("Create")] //this was added/explained in session 11 about 6 mins in
        public ActionResult Create_Post()
        {

            Customers customer = new Customers();
            TryUpdateModel(customer);
            //above must be TryUpdateModel & [Required] in BLL 
            //Customer.cs in order for data annotations to work in/on create view page
            if (ModelState.IsValid)
            {

                CustomerBLL cbl = new CustomerBLL();
                cbl.AddCustomer(customer);

                return RedirectToAction("Index");
            }

            return View();
        }


 















        //[HttpGet]
        //public ActionResult Edit(int CustomerID)
        //{

        //    CustomerBLL custBll = new CustomerBLL();
        //    Customers cust = custBll.xCustomers.Single(custom => custom.CustomerID == CustomerID);


        //    //Customers customer = custBll.xCustomers.Single(cust => cust.CustomerID == customerID);

        //    return View(cust);

        //}






    }
}