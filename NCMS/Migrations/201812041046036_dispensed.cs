namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dispensed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pharmacists", "DispensedDrugs", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pharmacists", "DispensedDrugs");
        }
    }
}
