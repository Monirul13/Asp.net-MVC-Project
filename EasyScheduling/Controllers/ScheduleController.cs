using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataRepository;
using System.Web.Services;
using System.Web.Script.Services;

namespace EasyScheduling.Controllers
{
    public class ScheduleController : Controller
    {

        // GET: Schedule
        SchedulingDataContext context = new SchedulingDataContext();
        public ActionResult Index()
        {
            
            FacultyAssign fa = new FacultyAssign();
            return View(fa.GenerateRoutine());
            
        }
        public ActionResult GenarateRoutine()
        {

            return View();

        }
        public ActionResult ajax()
        {
            string item = Request["search"];
            List<MakeRoutine> result = new List<MakeRoutine>();
            result = (from r in context.MakeRoutines
                           where r.FacultyName == item
                           select r).ToList();
            FacultyAssign fa = new FacultyAssign();
            return View(result);

        }
        public ActionResult Refresh()
        {
            MakeRoutineRepository mk = new MakeRoutineRepository();
            mk.DeleteAll();
            return RedirectToAction("Index");
        }




        public JsonResult GetFacultyName(string search)
            {
           SchedulingDataContext db = new SchedulingDataContext();
            List<string> allsearch = new List<string>();
           allsearch = db.Faculties.Where(x => x.Name.Contains(search)).Select(x => x.Name).ToList();
    
        
            return new JsonResult { Data = allsearch, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


        }
    }
}