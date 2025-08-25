using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty Dashboard
        public ActionResult Index()
        {
            // Ensure only Faculty can access
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Faculty")
            {
                return RedirectToAction("Login", "Accounts");
            }

            // Optional: pass some hardcoded counts for dashboard
            ViewBag.TotalStudents = 50;       // e.g., students under this faculty
            ViewBag.TotalBooks = 200;         // total books handled/issued by faculty
            ViewBag.AssignedClasses = 5;      // number of classes assigned
            ViewBag.Events = 3;               // events organized by this faculty

            return View();
        }
    }
}