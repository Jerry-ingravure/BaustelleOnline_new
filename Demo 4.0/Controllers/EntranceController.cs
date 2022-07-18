using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demo_4._0.Models;

namespace Demo_4._0.Controllers
{
    public class EntranceController : Controller
    {
        private inGravureEntities db = new inGravureEntities();

        // GET: Entrance
        public ActionResult Index()
        {
            var po_avise_entrance_unloading = db.po_avise_entrance_unloading.Include(p => p.po_avise_requests);
            return View(po_avise_entrance_unloading.ToList());
        }

        // GET: Entrance/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_entrance_unloading po_avise_entrance_unloading = db.po_avise_entrance_unloading.Find(id);
            if (po_avise_entrance_unloading == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_entrance_unloading);
        }

        // GET: Entrance/Create
        public ActionResult Create()
        {
            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "uid");
            return View();
        }

        // POST: Entrance/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uid,fk_po_avise_request_uid,ordered_by,unloading_location,type_of_verhicle,arrival_time,dur,status")] po_avise_entrance_unloading po_avise_entrance_unloading)
        {
            if (ModelState.IsValid)
            {
                po_avise_entrance_unloading.uid = Guid.NewGuid();
                db.po_avise_entrance_unloading.Add(po_avise_entrance_unloading);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "material", po_avise_entrance_unloading.fk_po_avise_request_uid);
            return View(po_avise_entrance_unloading);
        }

        // GET: Entrance/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_entrance_unloading po_avise_entrance_unloading = db.po_avise_entrance_unloading.Find(id);
            if (po_avise_entrance_unloading == null)
            {
                return HttpNotFound();
            }
            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "uid", po_avise_entrance_unloading.fk_po_avise_request_uid);
            return View(po_avise_entrance_unloading);
        }

        // POST: Entrance/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uid,fk_po_avise_request_uid,ordered_by,unloading_location,type_of_verhicle,arrival_time,dur,status")] po_avise_entrance_unloading po_avise_entrance_unloading)
        {
            if (ModelState.IsValid)
            {
                db.Entry(po_avise_entrance_unloading).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "uid", po_avise_entrance_unloading.fk_po_avise_request_uid);
            return View(po_avise_entrance_unloading);
        }

        // GET: Entrance/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_entrance_unloading po_avise_entrance_unloading = db.po_avise_entrance_unloading.Find(id);
            if (po_avise_entrance_unloading == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_entrance_unloading);
        }

        // POST: Entrance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            po_avise_entrance_unloading po_avise_entrance_unloading = db.po_avise_entrance_unloading.Find(id);
            db.po_avise_entrance_unloading.Remove(po_avise_entrance_unloading);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
