namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drugdispense : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestDrugs",
                c => new
                    {
                        RequestID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        GenericName = c.String(),
                        Quantity = c.Double(nullable: false),
                        Description = c.String(),
                        RequestBy = c.String(),
                        RequestDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RequestID);
            
            AddColumn("dbo.Pharmacists", "FullName", c => c.String());
            AddColumn("dbo.Pharmacists", "DrugId", c => c.Int(nullable: false));
            AddColumn("dbo.Pharmacists", "BrandName", c => c.String());
            AddColumn("dbo.Pharmacists", "GenericName", c => c.String());
            AddColumn("dbo.Pharmacists", "Strength", c => c.String());
            AddColumn("dbo.Pharmacists", "Quantity", c => c.Double(nullable: false));
            AddColumn("dbo.Pharmacists", "RemainingDrugs", c => c.Double(nullable: false));
            AddColumn("dbo.Pharmacists", "UploadedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pharmacists", "Surname");
            DropColumn("dbo.Pharmacists", "Othernames");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pharmacists", "Othernames", c => c.String());
            AddColumn("dbo.Pharmacists", "Surname", c => c.String());
            DropColumn("dbo.Pharmacists", "UploadedDate");
            DropColumn("dbo.Pharmacists", "RemainingDrugs");
            DropColumn("dbo.Pharmacists", "Quantity");
            DropColumn("dbo.Pharmacists", "Strength");
            DropColumn("dbo.Pharmacists", "GenericName");
            DropColumn("dbo.Pharmacists", "BrandName");
            DropColumn("dbo.Pharmacists", "DrugId");
            DropColumn("dbo.Pharmacists", "FullName");
            DropTable("dbo.RequestDrugs");
        }
    }
}
