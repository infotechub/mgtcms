namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewRwquestDrugs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequestDrugs", "QuantityReq", c => c.Double(nullable: false));
            AddColumn("dbo.RequestDrugs", "DispensedQuantity", c => c.Double(nullable: false));
            AddColumn("dbo.RequestDrugs", "ReceivedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.RequestDrugs", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RequestDrugs", "Quantity", c => c.Double(nullable: false));
            DropColumn("dbo.RequestDrugs", "ReceivedDate");
            DropColumn("dbo.RequestDrugs", "DispensedQuantity");
            DropColumn("dbo.RequestDrugs", "QuantityReq");
        }
    }
}
