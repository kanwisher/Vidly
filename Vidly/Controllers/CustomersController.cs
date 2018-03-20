using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int Id)
        {

            var customers = GetCustomers();
            var customer = customers.Find(x => x.Id == Id);
            if (customer != null)
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
            
            
        }

        private static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer() {Id = 1, Name = "David Kanwisher"},
                new Customer() {Id = 2, Name = "Mirsada Haticic"}
            };

            return customers;

        }
    }
}