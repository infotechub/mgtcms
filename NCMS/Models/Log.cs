using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public class Log
    {
        [Key]
        [DisplayName("#")]
        public int LogId { get; set; }
        [DisplayName("Action")]
        public string Action { get; set; }
        [DisplayName("Action Description")]
        public string ActionDescription { get; set; }
        public string Page { get; set; }
        [DisplayName("Action Taken By")]
        public string ActiontakenBy { get; set; }
        [DisplayName("Date")]
        public DateTime ActionDate { get; set; }
    }
}