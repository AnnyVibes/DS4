﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorioo_18._1.Controllers
{
    public class AccesController : Controller
    {
        // GET: Acces
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Enter(String user, string password)
        {
            try
            {
                return Content("1");

            }
            catch(Exception ex)
            {
                return Content("Ocurrio un error:  (" + ex.Message);
            }
        }
    }
}