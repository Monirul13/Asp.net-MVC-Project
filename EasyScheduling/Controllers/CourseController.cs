using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataRepository;
namespace EasyScheduling.Controllers
{
    public class CourseController : Controller
    {
        private CourseRepository cp = new CourseRepository();
        [HttpGet]
        public ActionResult Index()
        {

            return View(this.cp.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Course co)
        {

            if (ModelState.IsValid)
            {
                this.cp.Insert(co);
                return RedirectToAction("Index");
            }
            else
            {
                return View(co);
            }
        }
    }
}