using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webForVueApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult LoginIn()
        {
            return View();
        }
    }
}