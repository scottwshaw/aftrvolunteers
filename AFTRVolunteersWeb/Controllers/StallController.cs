using System.Data;
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
            ViewBag.People = db.People.ToList();
            return View();
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
            Stall stall = db.Stalls.Find(id);
            if (stall == null)
            {
                return HttpNotFound();
            }
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