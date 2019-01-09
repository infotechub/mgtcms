namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UploadedBy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pharmacists", "UploadedBy", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pharmacists", "UploadedBy");
        }
    }
}
