using QL_KHOnl_CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QL_KHOnl_CF.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        CourseDBContext db = new CourseDBContext();
        public ActionResult Index()
        {
            List<COURSE> list = db.COURSES.ToList(); 
            return View(list);
        }
    }
}