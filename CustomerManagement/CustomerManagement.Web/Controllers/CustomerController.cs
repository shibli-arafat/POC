using CustomerManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerManagement.Web.Controllers
{
    public class CustomerController : Controller
    {
        private static CustomerCollection _Customers;

        static CustomerController()
        {
            _Customers = new CustomerCollection();
            Customer cust = new Customer();
            cust.Id = 1;
            cust.FirstName = "Shibli";
            cust.MiddleName = "Mohammad";
            cust.LastName = "Arafat";
            cust.Address = "Dhammondi, Dhaka";
            cust.MobileNo = "0171";
            _Customers.Add(cust);
            cust = new Customer();
            cust.Id = 2;
            cust.FirstName = "Erfana";
            cust.MiddleName = "";
            cust.LastName = "Sikder";
            cust.Address = "Gulshan, Dhaka";
            cust.MobileNo = "0181";
            _Customers.Add(cust);
            cust = new Customer();
            cust.Id = 3;
            cust.FirstName = "Iffat";
            cust.MiddleName = "";
            cust.LastName = "Jabin";
            cust.Address = "Khilkhet, Dhaka";
            cust.MobileNo = "0161";
            _Customers.Add(cust);
        }

        public ActionResult Index()
        {            
            return View(_Customers);
        }

        //
        // GET: /Customer/Details/5

        public ActionResult Details(int id)
        {
            ViewBag.Message = string.Format("Details of Customer: {0}", id);
            return View(_Customers.Find(x=> x.Id == id));
        }

        [HttpPost]
        public ActionResult Details(Customer customer)
        {
            //ViewBag.Message = string.Format("Details of Customer: {0}", id);
            _Customers.Update(customer);
            return RedirectToAction("Index");
        }

        //
        // GET: /Customer/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Customer/Create

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

        //
        // GET: /Customer/Edit/5

        public ActionResult Edit(int id)
        {
            ViewBag.Message = string.Format("Details of Customer: {0}", id);
            return View(_Customers.Find(x => x.Id == id));
        }

        //
        // POST: /Customer/Edit/5

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            //ViewBag.Message = string.Format("Details of Customer: {0}", id);
            _Customers.Update(customer);
            return RedirectToAction("Index");
        }

        //
        // GET: /Customer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Customer/Delete/5

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
    }
}
