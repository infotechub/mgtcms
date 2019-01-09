using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public class RequestDrugs
    {
        [Key]
        [DisplayName("Request ID")]
        public int RequestID { get; set; }
        [DisplayName("Brand Name")]
        public string BrandName { get; set; }
        [DisplayName("Generic Name")]
        public string GenericName { get; set; }
        public double Quantity { get; set; }
        [DisplayName("Remark")]
        public string Description { get; set; }
        [DisplayName("Request Made By")]
        public string RequestBy { get; set; }
        [DisplayName("Dispensed By")]
        public string DispensedBy { get; set; }
        [DisplayName("Reviewed By")]
        public string ReviewedBy { get; set; }
        [DisplayName("Comment")]
        public string Comment { get; set; }
        [DisplayName("Request Date")]
        public DateTime RequestDate { get; set; }
        [DisplayName("Dispensed Date")]
        [DataType(DataType.Date)]
        public string DispensedDate { get; set; }
        [DisplayName("Reviewed Date")]
        [DataType(DataType.Date)]
        public string ReviewedDate { get; set; }
        [DisplayName("Remark")]
        public string ReviewedRemark { get; set; }
    }
}