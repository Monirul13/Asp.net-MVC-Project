using DataRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyScheduling.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        private RoomRepository rp = new RoomRepository();
        public ActionResult Index()
        {

            return View(this.rp.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Room ro)
        {
            if (ModelState.IsValid)
            {
                this.rp.Insert(ro);
                return RedirectToAction("Index");
            }
            else
            {
                return View(ro);
            }

        }
    }
}