﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

<<<<<<< Updated upstream
        public ActionResult Detail(int id)
=======
        public ActionResult Detail(string Conflict)
>>>>>>> Stashed changes
        {
            return View();
        }

    }
}