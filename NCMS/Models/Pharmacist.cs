using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public class Pharmacist
    {
        [Key]
        [DisplayName("#")]
        public int PrescriptionId { get; set; }
        [DisplayName("Policy Number")]
        public string PolicyNumber { get; set; }
        [DisplayName("Full Name")]
        [DataType(DataType.Text)]
        public string FullName { get; set; }
        [DisplayName("Presenting Complain")]
        [DataType(DataType.MultilineText)]
        public string PresentingComplain { get; set; }
        [DisplayName("Diagnosis")]
        [DataType(DataType.Text)]
        public string Diagnosis { get; set; }
        [DisplayName("Prescribe Drugs")]
        [DataType(DataType.MultilineText)]
        public string PrescribeDrugs { get; set; }
        [DisplayName("Drug Description ")]
        [DataType(DataType.MultilineText)]
        public string DrugDescription { get; set; }
        [DisplayName("Drug Usage")]
        public string DrugUsage { get; set; }
        [DisplayName("Is Drug Prescribed")]
        public string DrugPrescribed { get; set; }
        [DisplayName("Prescribed By")]
        [DataType(DataType.Text)]
        public string PrescribeBy { get; set; }
        [DisplayName("Is Drug Issued?")]
        public bool IsDrugIssued { get; set; }
        [DisplayName("Drug Issued By")]
        [DataType(DataType.Text)]
        public string IssuedBy { get; set; }
        [DisplayName("Drug ID")]
        public int DrugId { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
        [DisplayName("Generic Name")]
        public string GenericName { get; set; }
        [DisplayName("Drug Strength")]
        public string Strength { get; set; }
        [DisplayName("Drug Quantity")]
        public Double Quantity { get; set; }
        [DisplayName("Drug Given")]
        public Double QuantityUploaded { get; set; }
        [DisplayName("Dispensed Drugs")]
        public Double DispensedDrugs { get; set; }
        [DisplayName("Undispensed Drugs")]
        public Double RemainingDrugs { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Drugs Uploaded On")]
        public DateTime UploadedDate { get; set; }
        [DisplayName("Drugs Uploaded By")]
        public DateTime UploadedBy { get; set; }
        [DisplayName("Reviewed By")]
        public string ReviewedBy { get; set; }
        [DisplayName("Comment")]
        public string Comment { get; set; }
        [DisplayName("ReviewedDate")]
        [DataType(DataType.DateTime)]
        public string Date { get; set; }

        public DateTime _createdon = DateTime.Now;
        [DisplayName("Ceated On")]
        public DateTime CreatedOn { get { return _createdon; } set { _createdon = value; } }



        [DataType(DataType.DateTime)]
        [DisplayName("Dispense Date")]
        public DateTime DrugIssuedOn { get; set; }

        [DisplayName("Appointment ID")]
        public long AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        
    }
}