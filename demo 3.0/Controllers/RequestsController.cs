using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace demo_3._0.Models
{
    public class RequestsController : Controller
    {
        private inGravureEntities6 db = new inGravureEntities6();

        // GET: Requests
        public ActionResult Index()
        {
            return View(db.po_avise_requests.ToList());
        }

        // GET: Requests/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_requests po_avise_requests = db.po_avise_requests.Find(id);
            if (po_avise_requests == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_requests);
        }

        // GET: Requests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uid,fk_po_avise_request_uid,material,supplier,qty,uom,unloading")] po_avise_requests po_avise_requests)
        {
            if (ModelState.IsValid)
            {
                po_avise_requests.uid = Guid.NewGuid();
                db.po_avise_requests.Add(po_avise_requests);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(po_avise_requests);
        }

        // GET: Requests/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_requests po_avise_requests = db.po_avise_requests.Find(id);
            if (po_avise_requests == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_requests);
        }

        // POST: Requests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uid,fk_po_avise_request_uid,material,supplier,qty,uom,unloading")] po_avise_requests po_avise_requests)
        {
            if (ModelState.IsValid)
            {
                db.Entry(po_avise_requests).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(po_avise_requests);
        }

        // GET: Requests/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            po_avise_requests po_avise_requests = db.po_avise_requests.Find(id);
            if (po_avise_requests == null)
            {
                return HttpNotFound();
            }
            return View(po_avise_requests);
        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            po_avise_requests po_avise_requests = db.po_avise_requests.Find(id);
            db.po_avise_requests.Remove(po_avise_requests);
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
