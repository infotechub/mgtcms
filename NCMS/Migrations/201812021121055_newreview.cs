namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newreview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pharmacists", "ReviewedBy", c => c.String());
            AddColumn("dbo.Pharmacists", "Comment", c => c.String());
            AddColumn("dbo.Pharmacists", "Date", c => c.String());
            DropColumn("dbo.Appointments", "ReviewedBy");
            DropColumn("dbo.Appointments", "Comment");
            DropColumn("dbo.Appointments", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Date", c => c.String());
            AddColumn("dbo.Appointments", "Comment", c => c.String());
            AddColumn("dbo.Appointments", "ReviewedBy", c => c.String());
            DropColumn("dbo.Pharmacists", "Date");
            DropColumn("dbo.Pharmacists", "Comment");
            DropColumn("dbo.Pharmacists", "ReviewedBy");
        }
    }
}
