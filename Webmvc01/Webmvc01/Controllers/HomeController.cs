using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc01.Models;
namespace Webmvc01.Controllers
{
    public class HomeController : Controller
    {
        ShoppingEntities shpEntity = new ShoppingEntities();
        // GET: Home
        public ActionResult Index()
        {
            String PgName = "Home";
            ViewBag.PageTitle = PgName;
            return View();
        }

 

        public ActionResult AboutUs()
        {
            Contact ac = new Contact {ContactId=100,Location= "Karachi",Address= "Happy Homes Decent Arcade anbcbajj " };
            ViewBag.PageTitle = ac;
            return View();
        }
        private List<Contact> _lstContact = null;
        public ActionResult ListOfContact()
        {
            _lstContact = new List<Contact>();
            _lstContact.Add(new Contact { ContactId = 100, Location = "Karachi", Address = "Happy Homes Decent Arcade anbcbajj " });
            _lstContact.Add(new Contact {ContactId = 101,Location="Lahore",Address="Adjsadjsajd" });
            _lstContact.Add(new Contact { ContactId = 102, Location = "Lahore", Address = "Malik Raiz House" });

            ViewBag.PageTitle = _lstContact;
            return View();
        }
        public ActionResult ListOfCustomer()
        {
            var data = shpEntity.Customers.ToList();

            ViewBag.PageTitle = data;
            return View();
        }

        }
    }