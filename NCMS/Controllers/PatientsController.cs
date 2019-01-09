using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NCMS.Models;
using PagedList;

namespace NCMS.Controllers
{
    
    [Authorize]
    public class PatientsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Patients
        public ActionResult Index(string option, string search, int? pageNumber)
        {

            
                //return View(db.Patients.Where(x => x.Emailaddress.StartsWith(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));

            if (option == "PolicyNumber")
            {
                return View(db.Patients.Where(x => x.PolicyNumber == search || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }
            else if (option == "Mobilenumber")
            {
                return View(db.Patients.Where(x => x.Mobilenumber == search || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }
           
            else
            {
                return View(db.Patients.Where(x => x.Emailaddress.StartsWith(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }
        }

        // GET: Patients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // GET: Patients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PatientId,FullName,Dob,PolicyNumber,Maritalstatus,Occupation,Sex,HasProfile,Profileid,StaffId,Mobilenumber,Emailaddress,NewStaffId,CreatedOn,UpdatedOn")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patient);
        }

        // GET: Patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PatientId,FullName,Dob,PolicyNumber,Maritalstatus,Occupation,Sex,HasProfile,Profileid,StaffId,Mobilenumber,Emailaddress,NewStaffId,CreatedOn,UpdatedOn")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patient);
        }

        // GET: Patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Patient patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Patient patient = db.Patients.Find(id);
            db.Patients.Remove(patient);
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
