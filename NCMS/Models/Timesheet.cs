using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public class Timesheet
    {
        [DisplayName("S/N")]
        public int Id { get; set; }
        public long TimesheetId { get; set; }
        public string Email { get; set; }
    
        [DisplayName("Time In")]
        public string TimeIn { get; set; }
        [DisplayName("Time Out")]
        public string TimeOut { get; set; }
        public string Comment { get; set; }
        [DisplayName("Work Hours")]
        public string NoOfHours { get; set; }
        public DateTime _date = System.DateTime.Now;
        [DisplayName("Created On")]
        public DateTime DateCreated { get { return _date; } set { _date = value; } }
    }
}