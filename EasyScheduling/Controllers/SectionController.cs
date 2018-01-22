using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataRepository;
namespace EasyScheduling.Controllers
{
    public class SectionController : Controller
    {

        // GET: Section
        private SectionRepository repo = new SectionRepository();
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
        public ActionResult Create(Section sec)
        {
            if (ModelState.IsValid)
            {
                this.repo.Insert(sec);
                return RedirectToAction("Index");
            }
            else
            {
                return View(sec);
            }
        }
    }
}