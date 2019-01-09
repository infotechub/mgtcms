namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pharmacists", "QuantityUploaded", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pharmacists", "QuantityUploaded");
        }
    }
}
