using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataRepository;
namespace EasyScheduling.Controllers
{
    
    public class AdminController : Controller
    {
        private FacultyRepository repo = new FacultyRepository();
 


        public ActionResult Index()
        {
            return View(this.repo.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
      
            return View();
        }
        [HttpPost]
        public ActionResult Create(Faculty fa)
        {

            if (ModelState.IsValid)
            {
                this.repo.Insert(fa);
                return RedirectToAction("Index");
            }
            else
            {
                return View(fa);
            }

        }
       
        


    }
}