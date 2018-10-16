using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarriageLicence.Models;

namespace MarriageLicence.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MarriageLicenseViewModel vm)
        {

            if (ModelState.IsValid)
            {
                return View();
            }
            else

                  {

                return View(vm);
            }

                
        }


    }
}