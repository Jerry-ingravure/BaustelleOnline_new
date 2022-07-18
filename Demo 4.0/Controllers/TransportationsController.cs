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
    public class TransportationsController : Controller
    {
        private inGravureEntities db = new inGravureEntities();

        // GET: Transportations
        public ActionResult Index()
        {
            var po_avise_transportations = db.po_avise_transportations.Include(p => p.po_avise_requests);
            return View(po_avise_transportations.ToList());
        }

        // GET: Transportations/Details/5
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

        // GET: Transportations/Create
        public ActionResult Create()
        {
            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "uid");
            return View();
        }

        // POST: Transportations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uid,fk_po_avise_request_uid,start_time,duration,transport_typ,material,qty,uom,state")] po_avise_transportations po_avise_transportations)
        {
            if (ModelState.IsValid)
            {
                po_avise_transportations.uid = Guid.NewGuid();
                db.po_avise_transportations.Add(po_avise_transportations);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "uid", po_avise_transportations.fk_po_avise_request_uid);
            return View(po_avise_transportations);
        }

        // GET: Transportations/Edit/5
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
            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "uid", po_avise_transportations.fk_po_avise_request_uid);
            return View(po_avise_transportations);
        }

        // POST: Transportations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uid,fk_po_avise_request_uid,start_time,duration,transport_typ,material,qty,uom,state")] po_avise_transportations po_avise_transportations)
        {
            if (ModelState.IsValid)
            {
                db.Entry(po_avise_transportations).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.fk_po_avise_request_uid = new SelectList(db.po_avise_requests, "uid", "uid", po_avise_transportations.fk_po_avise_request_uid);
            return View(po_avise_transportations);
        }

        // GET: Transportations/Delete/5
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

        // POST: Transportations/Delete/5
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
