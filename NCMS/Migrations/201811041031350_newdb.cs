namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Emailaddress = c.String(),
                        Age = c.String(),
                        History = c.String(),
                        PresentingComplain = c.String(),
                        Diagnosis = c.String(),
                        PlanTest = c.String(),
                        PlanDrug = c.String(),
                        PlanReferral = c.String(),
                        BloodPresure = c.Double(nullable: false),
                        PulseRate = c.String(),
                        BodyTemperature = c.String(),
                        RespiratoryRate = c.String(),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        AppointmentDate = c.String(),
                        AppointmentTime = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        ReasonForDeletion = c.String(),
                        CancelledBy = c.String(),
                        BMI = c.String(),
                        Occupation = c.String(),
                        DischargedDate = c.String(),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Dob = c.String(),
                        PolicyNumber = c.String(),
                        Maritalstatus = c.Int(nullable: false),
                        Occupation = c.String(),
                        Sex = c.Int(nullable: false),
                        HasProfile = c.Boolean(nullable: false),
                        Profileid = c.Long(nullable: false),
                        StaffId = c.String(),
                        Mobilenumber = c.String(),
                        Emailaddress = c.String(),
                        NewStaffId = c.Boolean(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PatientId);
            
            CreateTable(
                "dbo.Pharmacists",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        PolicyNumber = c.String(),
                        Surname = c.String(),
                        Othernames = c.String(),
                        PresentingComplain = c.String(),
                        Diagnosis = c.String(),
                        PrescribeDrugs = c.String(),
                        DrugDescription = c.String(),
                        DrugUsage = c.String(),
                        DrugPrescribed = c.String(),
                        PrescribeBy = c.String(),
                        IsDrugIssued = c.Boolean(nullable: false),
                        IssuedBy = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        DrugIssuedOn = c.DateTime(nullable: false),
                        AppointmentId = c.Long(nullable: false),
                        Appointment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Appointments", t => t.Appointment_Id)
                .Index(t => t.Appointment_Id);
            
            CreateTable(
                "dbo.Deles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        Action = c.String(),
                        ActionDescription = c.String(),
                        Page = c.String(),
                        ActiontakenBy = c.String(),
                        ActionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScheduleId = c.Long(nullable: false),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MySchedule = c.String(),
                        Description = c.String(),
                        ScheduleDate = c.String(),
                        ScheduleTime = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Timesheets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimesheetId = c.Long(nullable: false),
                        Email = c.String(),
                        TimeIn = c.DateTime(nullable: false),
                        TimeOut = c.DateTime(nullable: false),
                        Comment = c.String(),
                        NoOfHours = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Designation = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Pharmacists", "Appointment_Id", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "PatientId", "dbo.Patients");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Pharmacists", new[] { "Appointment_Id" });
            DropIndex("dbo.Appointments", new[] { "PatientId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Timesheets");
            DropTable("dbo.Schedules");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Logs");
            DropTable("dbo.Deles");
            DropTable("dbo.Pharmacists");
            DropTable("dbo.Patients");
            DropTable("dbo.Appointments");
        }
    }
}
