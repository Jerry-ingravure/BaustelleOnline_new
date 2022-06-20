using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demo1.Models;

namespace Demo1.Controllers
{
    public class po_avise_transportationsController : Controller
    {
        private inGravureEntities2 db = new inGravureEntities2();

        // GET: po_avise_transportations
        public ActionResult Index()
        {
            return View(db.po_avise_transportations.ToList());
        }

        // GET: po_avise_transportations/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_transportations po_avise_transportations = db.po_avise_transportations.Find(id);
            if (po_avise_transportations == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_transportations);
        }

        // GET: po_avise_transportations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: po_avise_transportations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uid,po_avise_request_uid,transportation_id,delivery_date,clock_timing,number,means_of_transportation,material,state")] po_avise_transportations po_avise_transportations)
        {
            if (ModelState.IsValid)
            {
                po_avise_transportations.uid = Guid.NewGuid();
                db.po_avise_transportations.Add(po_avise_transportations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(po_avise_transportations);
        }

        // GET: po_avise_transportations/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_transportations po_avise_transportations = db.po_avise_transportations.Find(id);
            if (po_avise_transportations == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_transportations);
        }

        // POST: po_avise_transportations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uid,po_avise_request_uid,transportation_id,delivery_date,clock_timing,number,means_of_transportation,material,state")] po_avise_transportations po_avise_transportations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(po_avise_transportations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(po_avise_transportations);
        }

        // GET: po_avise_transportations/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_transportations po_avise_transportations = db.po_avise_transportations.Find(id);
            if (po_avise_transportations == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_transportations);
        }

        // POST: po_avise_transportations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            po_avise_transportations po_avise_transportations = db.po_avise_transportations.Find(id);
            db.po_avise_transportations.Remove(po_avise_transportations);
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
