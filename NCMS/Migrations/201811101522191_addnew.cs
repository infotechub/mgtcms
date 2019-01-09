namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnew : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "Name");
            DropColumn("dbo.Pharmacists", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pharmacists", "Name", c => c.String());
            AddColumn("dbo.Appointments", "Name", c => c.String());
        }
    }
}
