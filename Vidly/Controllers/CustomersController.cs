using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{Id = 1, Name="Andreea Catalina"},
                new Customer{Id = 2, Name="Alexandra Maria"}
            };

            var viewModel = new CustomersViewModels
            {
                Customers = customers
            };

            return View(viewModel);
        }

        //[Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer{Id = 1, Name="Andreea Catalina"},
                new Customer{Id = 2, Name="Alexandra Maria"}
            };

           
            var result = customers.Find(x => x.Id == id);

            if(result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }
    }
}