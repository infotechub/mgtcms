using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public class Appointment
    {
        [Key]
        [DisplayName("#")]
        public int Id { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Emailaddress { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public string Age { get; set; }
        [DisplayName("Examination")]
        [DataType(DataType.MultilineText)]
        public string History { get; set; }
        [DisplayName("Presenting Complain")]
        [DataType(DataType.MultilineText)]
        public string PresentingComplain { get; set; }
        [DataType(DataType.MultilineText)]
        public string Diagnosis { get; set; }
        [DisplayName("Plan Test")]
        [DataType(DataType.MultilineText)]
        public string PlanTest { get; set; }
        [DisplayName("Plan Drug")]
        [DataType(DataType.Text)]
        public string PlanDrug { get; set; }
        [DisplayName("Referral")]
        [DataType(DataType.Text)]
        public string PlanReferral { get; set; }
        [DisplayName("Blood Pressure(mm Hg)")]
        public double BloodPresure { get; set; }
        [DisplayName("Pulse Rate")]
        public string PulseRate { get; set; }
        [DisplayName("Body Temperature")]
        [DataType(DataType.Text)]
        public string BodyTemperature { get; set; }
        [DisplayName("Respiratory Rate")]
        [DataType(DataType.Text)]
        public string RespiratoryRate { get; set; }
        [DisplayName("Weight(kg)")]
        [DataType(DataType.Text)]
        public double Weight { get; set; }
        [DisplayName("Height(metres)")]
        [DataType(DataType.Text)]
        public double Height { get; set; }
        [DisplayName("Appointment Date")]
        [DataType(DataType.Date)]
        public string AppointmentDate { get; set; }
        [DisplayName("Appointment Time")]
        [DataType(DataType.Time)]
        public string AppointmentTime { get; set; }
        [DisplayName("Appointment Status")]
        public Status Status { get; set; }
       
        public DateTime _createdon = DateTime.Now;
        public DateTime CreatedOn { get { return _createdon; } set { _createdon = value; } }
    
        public DateTime _updatedon = DateTime.Now;
        public DateTime UpdatedOn { get { return _updatedon; } set { _updatedon = value; } }
        [DisplayName("Reason for Cancellation")]
        [DataType(DataType.MultilineText)]
        public string ReasonForDeletion { get; set; }
        [DisplayName("Cancelled By")]
        [DataType(DataType.Text)]
        public string CancelledBy { get; set; }
        public string BMI { get; set; }
        public string Occupation { get; set; }
        [DisplayName("Discharge Date")]
        public string DischargedDate { get; set; }
    


        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public virtual ICollection<Pharmacist> Pharmacists { get; set; }
    }
}