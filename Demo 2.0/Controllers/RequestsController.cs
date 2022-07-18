using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demo_2._0.Models;

namespace Demo_2._0.Controllers
{
    public class RequestsController : Controller
    {
        private inGravureEntities db = new inGravureEntities();

        // GET: Requests
        public ViewResult Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var requests = from s in db.po_avise_requests
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                requests = requests.Where(s => s.Besteller.Contains(searchString)
                                       || s.Besteller.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    requests = requests.OrderByDescending(s => s.Besteller);
                    break;
                case "Date":
                    requests= requests.OrderBy(s => s.Zeitpunkt);
                    break;
                case "date_desc":
                    requests = requests.OrderByDescending(s => s.Zeitpunkt);
                    break;
                default:
                    requests = requests.OrderBy(s => s.Besteller);
                    break;
            }

            return View(requests.ToList());
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
        public ActionResult Create([Bind(Include = "uid,po_no,Zeitpunkt,Besteller,item_description,off_loading_advise,Entladung,status")] po_avise_requests po_avise_requests)
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
        public ActionResult Edit([Bind(Include = "uid,po_no,Zeitpunkt,Besteller,item_description,off_loading_advise,Entladung,status")] po_avise_requests po_avise_requests)
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
