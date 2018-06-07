using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers/")]
        public ActionResult Index()
        {
            var customer1 = new Customer {Name = "Diogo Watson"};
            var customer2 = new Customer {Name = "Denise Terra"};

            return View();
        }
    }
}