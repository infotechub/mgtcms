using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCMS.Models
{
    public enum Status
    {
        
        Active,
        Suspended,
        DrugsPrescribed,
        DrugsIssued,
        Cancelled,
        Completed

    }

    public enum Gender
    {
        Sex,
        Male,
        Female

    }

    public enum Designation
    {
        Designation,
        FrontDesk,
        Nurse,
        Pharmarcist,
        Doctor,
        DrugAdmin

    }
}