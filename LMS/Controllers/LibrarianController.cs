using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class LibrarianController : Controller
    {
        // GET: Librarian Dashboard
        public ActionResult Index()
        {
            // Ensure only Librarian can access
            if (Session["UserRole"] == null || Session["UserRole"].ToString() != "Librarian")
            {
                return RedirectToAction("Login", "Accounts");
            }

            // Dummy data for Librarian dashboard
            ViewBag.TotalBooks = 500;
            ViewBag.BooksIssued = 120;
            ViewBag.BooksReserved = 45;
            ViewBag.OverdueBooks = 10;

            return View();
        }
    }
}