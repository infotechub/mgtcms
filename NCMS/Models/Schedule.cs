using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public class Schedule
    {
        [Key]
        [DisplayName("#")]
        public int Id { get; set; }
        [DisplayName("Schedule ID")]
        public long ScheduleId { get; set; }
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("My Schedule")]
        public string MySchedule { get; set; }
        public string Description { get; set; }
        [DisplayName("Schedule Date")]
        [DataType(DataType.Date)]
        public string ScheduleDate { get; set; }
        [DisplayName("Schedule Time")]
        [DataType(DataType.Time)]
        public string ScheduleTime { get; set; }
        public DateTime _datecreated = DateTime.Now;
        public DateTime DateCreated { get { return _datecreated; } set { _datecreated = value; } }

        public DateTime _updatedon = DateTime.Now;
        public DateTime UpdatedOn { get { return _updatedon; } set { _updatedon = value; } }
    }
}