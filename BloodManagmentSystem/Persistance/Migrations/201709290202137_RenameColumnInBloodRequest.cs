namespace BloodManagmentSystem.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameColumnInBloodRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BloodRequests", "DueDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.BloodRequests", "DueDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodRequests", "DueDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.BloodRequests", "DueDateTime");
        }
    }
}
