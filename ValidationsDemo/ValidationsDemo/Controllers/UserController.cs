using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationsDemo.Models;
namespace ValidationsDemo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Register register)
        {
            if (ModelState.IsValid)
            {
                //  Your save logic goes here
                return Content("You are register successfully");
            }
            else
            {
                return View("Register");
            }
        }
    }
}