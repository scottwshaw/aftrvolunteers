using System.Data;
using System.Linq;
using System.Web.Mvc;
using AFTRVolunteersWeb.Models;

namespace AFTRVolunteersWeb.Controllers
{
    public class TimeSlotController : Controller
    {
        private VolunteerContext db = new VolunteerContext();

        //
        // GET: /TimeSlot/

        public ActionResult Index()
        {
            return View(db.TimeSlots.ToList());
        }

        //
        // GET: /TimeSlot/Details/5

        public ActionResult Details(int id = 0)
        {
            TimeSlot timeslot = db.TimeSlots.Find(id);
            if (timeslot == null)
            {
                return HttpNotFound();
            }
            return View(timeslot);
        }

        //
        // GET: /TimeSlot/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TimeSlot/Create

        [HttpPost]
        public ActionResult Create(TimeSlot timeslot)
        {
            if (ModelState.IsValid)
            {
                db.TimeSlots.Add(timeslot);
                db.SaveChanges();
                return RedirectToAction("Details", "Stall", new {id = timeslot.StallId});
            }
            return View();
        }

        //
        // GET: /TimeSlot/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TimeSlot timeslot = db.TimeSlots.Find(id);
            if (timeslot == null)
            {
                return HttpNotFound();
            }
            return View(timeslot);
        }

        //
        // POST: /TimeSlot/Edit/5

        [HttpPost]
        public ActionResult Edit(TimeSlot timeslot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeslot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timeslot);
        }

        //
        // GET: /TimeSlot/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TimeSlot timeslot = db.TimeSlots.Find(id);
            if (timeslot == null)
            {
                return HttpNotFound();
            }
            return View(timeslot);
        }

        //
        // POST: /TimeSlot/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeSlot timeslot = db.TimeSlots.Find(id);
            db.TimeSlots.Remove(timeslot);
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