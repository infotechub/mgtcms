using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public class Patient
    {
        [Key]
        [DisplayName("Patient ID")]
        public int PatientId { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public string Dob { get; set; }
        [DisplayName("Policy Number")]
        public string PolicyNumber { get; set; }
        [DisplayName("Marital Status")]
        public int Maritalstatus { get; set; }
        public string Occupation { get; set; }
        public int Sex { get; set; }
        [DisplayName("Has Profile?")]
        public bool HasProfile { get; set; }
        [DisplayName("Profile Id")]
        public long Profileid { get; set; }
        [DisplayName("Staff Id")]
        public string StaffId { get; set; }
        [DisplayName("Mobile Number")]
        public string Mobilenumber { get; set; }
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Emailaddress { get; set; }
        [DisplayName("New Staff ID")]
        public bool NewStaffId { get; set; }
        public DateTime _createdon = DateTime.Now;
        public DateTime CreatedOn { get { return _createdon; } set { _createdon = value; } }

        public DateTime _updatedon = DateTime.Now;
        public DateTime UpdatedOn { get { return _updatedon; } set { _updatedon = value; } }


        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}