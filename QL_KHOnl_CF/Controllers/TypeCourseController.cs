using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_KHOnl_CF.Models;

namespace QL_KHOnl_CF.Controllers
{
    public class TypeCourseController : Controller
    {
        // GET: TypeCourse
        public ActionResult Index()
        {
            CourseDBContext db = new CourseDBContext();
            List<TYPE_COURSE> lstTC = db.TYPE_COURSES.ToList();
            return View(lstTC);
        }
    }
}