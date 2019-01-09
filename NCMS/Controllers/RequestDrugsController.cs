using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NCMS.Models;
using PagedList;

namespace NCMS.Controllers
{
    public class RequestDrugsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RequestDrugs
        public ActionResult Index(string option, string search, int? pageNumber)
        {

            if (option == "GenericName")
            {

                return View(db.RequestDrugs.Where(x => x.GenericName == search || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }
            else
            {
                return View(db.RequestDrugs.Where(x => x.BrandName.StartsWith(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }
            //var appointments = db.Appointments.Include(a => a.Patient);
            //return View(appointments.ToList());
        }
       
        // GET: RequestDrugs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestDrugs requestDrugs = db.RequestDrugs.Find(id);
            if (requestDrugs == null)
            {
                return HttpNotFound();
            }
            return View(requestDrugs);
        }

        // GET: RequestDrugs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequestDrugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RequestID,BrandName,GenericName,Quantity,Description,RequestBy,ReviewedBy,Comment,RequestDate")] RequestDrugs requestDrugs)
        {
            if (ModelState.IsValid)
            {
                db.RequestDrugs.Add(requestDrugs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(requestDrugs);
        }

        // GET: RequestDrugs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestDrugs requestDrugs = db.RequestDrugs.Find(id);
            if (requestDrugs == null)
            {
                return HttpNotFound();
            }
            return View(requestDrugs);
        }

        // POST: RequestDrugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RequestID,BrandName,GenericName,Quantity,Description,RequestBy,ReviewedBy,Comment,RequestDate")] RequestDrugs requestDrugs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(requestDrugs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(requestDrugs);
        }

        // GET: RequestDrugs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestDrugs requestDrugs = db.RequestDrugs.Find(id);
            if (requestDrugs == null)
            {
                return HttpNotFound();
            }
            return View(requestDrugs);
        }

        // POST: RequestDrugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RequestDrugs requestDrugs = db.RequestDrugs.Find(id);
            db.RequestDrugs.Remove(requestDrugs);
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
