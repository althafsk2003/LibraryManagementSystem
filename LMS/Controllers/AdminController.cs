using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin Dashboard
        public ActionResult Index()
        {
            // Ensure only Admin can access
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Admin")
            {
                return RedirectToAction("Login", "Accounts");
            }

            // Optional: pass some hardcoded counts for dashboard
            ViewBag.TotalStudents = 120;
            ViewBag.TotalFaculty = 35;
            ViewBag.TotalLibrarians = 10;
            ViewBag.TotalBooks = 450;

            return View();
        }
    }
}