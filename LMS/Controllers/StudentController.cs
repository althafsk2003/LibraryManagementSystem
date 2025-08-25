using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMS.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student Dashboard
        public ActionResult Index()
        {
            // Dummy stats (can be replaced with DB values later)
            ViewBag.TotalBooksIssued = 5;
            ViewBag.TotalBooksReserved = 2;
            ViewBag.TotalOverdueBooks = 1;

            return View();
        }
    }
}