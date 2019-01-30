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
    public class InventoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Prescriptions
        public ActionResult Index(int? option, int? search, int? pageNumber)
        {
            {

                return View(db.Pharmacists.Where(x => x.AppointmentId == search || search == null).ToList().ToPagedList(pageNumber ?? 1, 10));
            }

            //return View(db.Pharmacists.ToList());
        }


        // GET: Prescriptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pharmacist pharmacist = db.Pharmacists.Find(id);
            if (pharmacist == null)
            {
                return HttpNotFound();
            }
            return View(pharmacist);
        }

        // GET: Prescriptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prescriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PrescriptionId,PolicyNumber,FullName,PresentingComplain,Diagnosis,PrescribeDrugs,DrugDescription,DrugUsage,DrugPrescribed,PrescribeBy,IsDrugIssued,IssuedBy,DrugId,BrandName,GenericName,Strength,Quantity,RemainingDrugs,UploadedDate,ReviewedBy,Comment,Date,CreatedOn,DrugIssuedOn,AppointmentId")] Pharmacist pharmacist)
        {

            //arithemtic operations
            double Quantity, DispensedDrugs, RemainingDrugs, QuantityUploaded;




            if (ModelState.IsValid)
            {
                db.Pharmacists.Add(pharmacist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pharmacist);
        }

        // GET: Prescriptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pharmacist pharmacist = db.Pharmacists.Find(id);
            if (pharmacist == null)
            {
                return HttpNotFound();
            }
            return View(pharmacist);
        }

        // POST: Prescriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PrescriptionId,PolicyNumber,FullName,PresentingComplain,Diagnosis,PrescribeDrugs,DrugDescription,DrugUsage,DrugPrescribed,PrescribeBy,IsDrugIssued,IssuedBy,DrugId,BrandName,GenericName,Strength,Quantity,RemainingDrugs,UploadedDate,ReviewedBy,Comment,Date,CreatedOn,DrugIssuedOn,AppointmentId")] Pharmacist pharmacist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pharmacist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pharmacist);
        }

        // GET: Prescriptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pharmacist pharmacist = db.Pharmacists.Find(id);
            if (pharmacist == null)
            {
                return HttpNotFound();
            }
            return View(pharmacist);
        }

        // POST: Prescriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pharmacist pharmacist = db.Pharmacists.Find(id);
            db.Pharmacists.Remove(pharmacist);
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
