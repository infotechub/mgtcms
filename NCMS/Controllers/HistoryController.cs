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
    public class HistoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: History
        public ActionResult Index(string option, string search, int? pageNumber)
        {

            if (option == "AppointmentDate")
            {

                return View(db.Appointments.Where(x => x.AppointmentDate == search || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }
            else
            {
                return View(db.Appointments.Where(x => x.Emailaddress.StartsWith(search) || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }
            //var appointments = db.Appointments.Include(a => a.Patient);
            //return View(appointments.ToList());
        }
        // GET: History/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = db.Appointments.Find(id);
            if (appointment == null)
            {
                return HttpNotFound();
            }
            return View(appointment);
        }

        // GET: History/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName");
            return View();
        }

        // POST: History/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,Emailaddress,Age,History,PresentingComplain,Diagnosis,PlanTest,PlanDrug,PlanReferral,BloodPresure,PulseRate,BodyTemperature,RespiratoryRate,Weight,Height,AppointmentDate,AppointmentTime,Status,CreatedOn,UpdatedOn,ReasonForDeletion,CancelledBy,BMI,Occupation,DischargedDate,PatientId")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                db.Appointments.Add(appointment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", appointment.Id);
            return View(appointment);
        }

        // GET: History/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = db.Appointments.Find(id);
            if (appointment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", appointment.Id);
            return View(appointment);
        }

        // POST: History/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,Emailaddress,Age,History,PresentingComplain,Diagnosis,PlanTest,PlanDrug,PlanReferral,BloodPresure,PulseRate,BodyTemperature,RespiratoryRate,Weight,Height,AppointmentDate,AppointmentTime,Status,CreatedOn,UpdatedOn,ReasonForDeletion,CancelledBy,BMI,Occupation,DischargedDate,PatientId")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patients, "PatientId", "FullName", appointment.Id);
            return View(appointment);
        }

        // GET: History/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = db.Appointments.Find(id);
            if (appointment == null)
            {
                return HttpNotFound();
            }
            return View(appointment);
        }

        // POST: History/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appointment appointment = db.Appointments.Find(id);
            db.Appointments.Remove(appointment);
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
