using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataRepository;
namespace EasyScheduling.Controllers
{
    public class RoutineController : Controller
    {
        // GET: Routine
        SectionRepository rp = new SectionRepository();
       
        public ActionResult Index(Section sk)
        {

            return View(rp.GetAll());
        }
        [HttpGet]
        public ActionResult AssignFaculty()
        {
            FacultyRepository facRepo = new FacultyRepository();
            CourseRepository crsRepo = new CourseRepository();
            List<SelectListItem>  facList = new List<SelectListItem>();
            List<SelectListItem> secList = new List<SelectListItem>();// a list of selectable items

            foreach (Faculty fac in facRepo.GetAll())
            {
                SelectListItem option = new SelectListItem();
                option.Text =  fac.Name;
                option.Value = fac.Id.ToString();

                facList.Add(option);
            }

            // sending the list to view through ViewBag
            ViewBag.faculties = facList;

            foreach (Course crs in crsRepo.GetAll())
            {
                SelectListItem option = new SelectListItem();
                option.Text = crs.CourseName;
                option.Value = crs.Id.ToString();

                secList.Add(option);
            }

            // sending the list to view through ViewBag
            ViewBag.courses = secList;

            return View();
        }
        [HttpPost]
        public ActionResult AssignFaculty(Section sk)
        {
            
            this.rp.Insert(sk);
            return RedirectToAction("Index");
        }
    }
}