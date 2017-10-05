namespace BloodManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReducePermittedLengthOfTheDonorName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Donors", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Donors", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
