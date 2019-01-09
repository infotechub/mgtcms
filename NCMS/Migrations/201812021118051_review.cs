namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class review : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "ReviewedBy", c => c.String());
            AddColumn("dbo.Appointments", "Comment", c => c.String());
            AddColumn("dbo.Appointments", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "Date");
            DropColumn("dbo.Appointments", "Comment");
            DropColumn("dbo.Appointments", "ReviewedBy");
        }
    }
}
