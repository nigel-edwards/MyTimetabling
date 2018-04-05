using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyTimetabling.DataAccessLayer;
using MyTimetabling.Models;

namespace MyTimetabling.Controllers
{
    public class RemissionController : Controller
    {
        private TimetableContext db = new TimetableContext();

        // GET: Remission
        public ActionResult Index()
        {
            return View(db.Remissions.ToList());
        }

        // GET: Remission/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remission remission = db.Remissions.Find(id);
            if (remission == null)
            {
                return HttpNotFound();
            }
            return View(remission);
        }

        // GET: Remission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Remission/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Description,Hours")] Remission remission)
        {
            if (ModelState.IsValid)
            {
                db.Remissions.Add(remission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(remission);
        }

        // GET: Remission/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remission remission = db.Remissions.Find(id);
            if (remission == null)
            {
                return HttpNotFound();
            }
            return View(remission);
        }

        // POST: Remission/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Description,Hours")] Remission remission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(remission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(remission);
        }

        // GET: Remission/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remission remission = db.Remissions.Find(id);
            if (remission == null)
            {
                return HttpNotFound();
            }
            return View(remission);
        }

        // POST: Remission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Remission remission = db.Remissions.Find(id);
            db.Remissions.Remove(remission);
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
