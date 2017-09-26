namespace BloodManagmentSystem.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBankToBloodRequest : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.BloodRequests", "BankId");
            AddForeignKey("dbo.BloodRequests", "BankId", "dbo.BloodBanks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BloodRequests", "BankId", "dbo.BloodBanks");
            DropIndex("dbo.BloodRequests", new[] { "BankId" });
        }
    }
}
