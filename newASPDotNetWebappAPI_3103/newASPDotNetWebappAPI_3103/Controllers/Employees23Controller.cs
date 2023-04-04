using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using newASPDotNetWebappAPI_3103.Models;

namespace newASPDotNetWebappAPI_3103.Controllers
{
    public class Employees23Controller : Controller
    {
        private SQLDbContext db = new SQLDbContext();

        // GET: Employees23
        public ActionResult Index()
        {
            return View(db.Employees23s.ToList());
        }

        // GET: Employees23/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees23 employees23 = db.Employees23s.Find(id);
            if (employees23 == null)
            {
                return HttpNotFound();
            }
            return View(employees23);
        }

        // GET: Employees23/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees23/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,Gender,Company,Designation")] Employees23 employees23)
        {
            if (ModelState.IsValid)
            {
                db.Employees23s.Add(employees23);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employees23);
        }

        // GET: Employees23/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees23 employees23 = db.Employees23s.Find(id);
            if (employees23 == null)
            {
                return HttpNotFound();
            }
            return View(employees23);
        }

        // POST: Employees23/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,Gender,Company,Designation")] Employees23 employees23)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employees23).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employees23);
        }

        // GET: Employees23/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employees23 employees23 = db.Employees23s.Find(id);
            if (employees23 == null)
            {
                return HttpNotFound();
            }
            return View(employees23);
        }

        // POST: Employees23/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Employees23 employees23 = db.Employees23s.Find(id);
            db.Employees23s.Remove(employees23);
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
