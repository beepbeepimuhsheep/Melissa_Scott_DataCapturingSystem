using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Melissa_Scott_9189_IPG521_FA1_Final.Data;
using Melissa_Scott_9189_IPG521_FA1_Final.Models;

namespace Melissa_Scott_9189_IPG521_FA1_Final.Controllers
{
    public class FacilitatorsController : Controller
    {
        private Melissa_Scott_9189_IPG521_FA1_FinalContext db = new Melissa_Scott_9189_IPG521_FA1_FinalContext();

        // GET: Facilitators
        public ActionResult Index()
        {
            return View(db.Facilitators.ToList());
        }

        // GET: Facilitators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilitator facilitator = db.Facilitators.Find(id);
            if (facilitator == null)
            {
                return HttpNotFound();
            }
            return View(facilitator);
        }

        // GET: Facilitators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facilitators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Surname,Address1,Address2,Email")] Facilitator facilitator)
        {
            if (ModelState.IsValid)
            {
                db.Facilitators.Add(facilitator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(facilitator);
        }

        // GET: Facilitators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilitator facilitator = db.Facilitators.Find(id);
            if (facilitator == null)
            {
                return HttpNotFound();
            }
            return View(facilitator);
        }

        // POST: Facilitators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Surname,Address1,Address2,Email")] Facilitator facilitator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facilitator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(facilitator);
        }

        // GET: Facilitators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facilitator facilitator = db.Facilitators.Find(id);
            if (facilitator == null)
            {
                return HttpNotFound();
            }
            return View(facilitator);
        }

        // POST: Facilitators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Facilitator facilitator = db.Facilitators.Find(id);
            db.Facilitators.Remove(facilitator);
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
