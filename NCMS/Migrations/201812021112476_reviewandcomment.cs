namespace NCMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reviewandcomment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RequestDrugs", "ReviewedBy", c => c.String());
            AddColumn("dbo.RequestDrugs", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RequestDrugs", "Comment");
            DropColumn("dbo.RequestDrugs", "ReviewedBy");
        }
    }
}
