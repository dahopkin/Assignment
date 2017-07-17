using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Domain.Entities;
using Assignment.Domain.Abstract;

namespace Assignment.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerRepository customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult SignUp(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerRepository.SaveCustomer(customer);
                return View("Thanks", customer);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
    }
}