namespace BloodManagmentSystem.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BloodRequestImprovement : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BloodRequests", "Bank_Id", "dbo.BloodBanks");
            DropIndex("dbo.BloodRequests", new[] { "Bank_Id" });
            AddColumn("dbo.BloodRequests", "BankId", c => c.Int(nullable: false));
            DropColumn("dbo.BloodRequests", "Bank_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BloodRequests", "Bank_Id", c => c.Int(nullable: false));
            DropColumn("dbo.BloodRequests", "BankId");
            CreateIndex("dbo.BloodRequests", "Bank_Id");
            AddForeignKey("dbo.BloodRequests", "Bank_Id", "dbo.BloodBanks", "Id", cascadeDelete: true);
        }
    }
}
