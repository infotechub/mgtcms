namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Timesheet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Timesheets", "TimeIn", c => c.String());
            AlterColumn("dbo.Timesheets", "TimeOut", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Timesheets", "TimeOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Timesheets", "TimeIn", c => c.DateTime(nullable: false));
        }
    }
}
