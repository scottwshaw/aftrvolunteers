using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using AFTRVolunteersWeb.Models;

namespace AFTRVolunteersWeb.Controllers
{
    public class StallController : Controller
    {
        private VolunteerContext db = new VolunteerContext();

        public ActionResult Index()
        {
            return View(db.Stalls.ToList());
        }

        public ActionResult Details(int id = 0)
        {
            Stall stall = db.Stalls.Find(id);
            if (stall == null)
            {
                return HttpNotFound();
            }
            return View(stall);
        }

        public ActionResult Create()
        {
            ViewBag.PeopleItems = PeoplSelectList();
            return View();
        }

        private List<SelectListItem> PeoplSelectList()
        {
            List<SelectListItem> items = db.People.ToList().Select(p => new SelectListItem
                {
                    Value = p.PersonId.ToString(CultureInfo.InvariantCulture),
                    Text = p.FullName()
                }).ToList();
            items.Insert(0, new SelectListItem
                {
                    Value = "",
                    Text = "--Choose One--"
                });
            return items;
        }

        [HttpPost]
        public ActionResult Create(Stall stall)
        {
            if (ModelState.IsValid)
            {
                db.Stalls.Add(stall);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stall);
        }

        public ActionResult Edit(int id = 0)
        {
            var stall = db.Stalls.Find(id);
            if (stall == null)
            {
                return HttpNotFound();
            }
            ViewBag.PeopleItems = PeoplSelectList();
            return View(stall);
        }

        [HttpPost]
        public ActionResult Edit(Stall stall)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stall).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stall);
        }

        public ActionResult Delete(int id = 0)
        {
            Stall stall = db.Stalls.Find(id);
            if (stall == null)
            {
                return HttpNotFound();
            }
            return View(stall);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Stall stall = db.Stalls.Find(id);
            db.Stalls.Remove(stall);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}