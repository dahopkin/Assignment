using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Domain.Entities;

namespace Assignment.WebUI.Controllers
{
    public class HomeController : Controller
    {
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
                //TODO: Email response to the party organizer.
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