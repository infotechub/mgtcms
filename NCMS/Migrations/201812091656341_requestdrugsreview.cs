namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class requestdrugsreview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequestDrugs", "DispensedBy", c => c.String());
            AddColumn("dbo.RequestDrugs", "DispensedDate", c => c.String());
            AddColumn("dbo.RequestDrugs", "ReviewedDate", c => c.String());
            AddColumn("dbo.RequestDrugs", "ReviewedRemark", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RequestDrugs", "ReviewedRemark");
            DropColumn("dbo.RequestDrugs", "ReviewedDate");
            DropColumn("dbo.RequestDrugs", "DispensedDate");
            DropColumn("dbo.RequestDrugs", "DispensedBy");
        }
    }
}
