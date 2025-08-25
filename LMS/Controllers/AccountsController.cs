using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Login Page
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            // Hardcoded logins for now
            if (email == "admin@uni.com" && password == "admin123")
            {
                Session["UserRole"] = "Admin";
                Session["UserEmail"] = email;
                return RedirectToAction("Index", "Admin");
            }
            else if (email == "student@uni.com" && password == "student123")
            {
                Session["UserRole"] = "Student";
                Session["UserEmail"] = email;
                return RedirectToAction("Index", "Student");
            }
            else if (email == "faculty@uni.com" && password == "faculty123")
            {
                Session["UserRole"] = "Faculty";
                Session["UserEmail"] = email;
                return RedirectToAction("Index", "Faculty");
            }
            else if (email == "librarian@uni.com" && password == "librarian123")
            {
                Session["UserRole"] = "Librarian";
                Session["UserEmail"] = email;
                return RedirectToAction("Index", "Librarian");
            }
            else
            {
                ViewBag.Error = "Invalid Email or Password!";
                return View();
            }
        }

        // GET: Logout
        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Accounts");
        }
    }
}