﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models;
namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult InsertData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertData(Mobile mb)
        {
            return View();
        }

    }
}