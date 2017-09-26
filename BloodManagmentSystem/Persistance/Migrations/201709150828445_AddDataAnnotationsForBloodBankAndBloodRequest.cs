using System.Data.Entity.Migrations;

namespace BloodManagmentSystem.Persistance.Migrations
{
    public partial class AddDataAnnotationsForBloodBankAndBloodRequest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BloodRequests", "Bank_Id", "dbo.BloodBanks");
            DropIndex("dbo.BloodRequests", new[] { "Bank_Id" });
            AlterColumn("dbo.BloodBanks", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.BloodBanks", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BloodRequests", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.BloodRequests", "Bank_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.BloodRequests", "Bank_Id");
            AddForeignKey("dbo.BloodRequests", "Bank_Id", "dbo.BloodBanks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BloodRequests", "Bank_Id", "dbo.BloodBanks");
            DropIndex("dbo.BloodRequests", new[] { "Bank_Id" });
            AlterColumn("dbo.BloodRequests", "Bank_Id", c => c.Int());
            AlterColumn("dbo.BloodRequests", "City", c => c.String());
            AlterColumn("dbo.BloodBanks", "City", c => c.String());
            AlterColumn("dbo.BloodBanks", "Name", c => c.String());
            CreateIndex("dbo.BloodRequests", "Bank_Id");
            AddForeignKey("dbo.BloodRequests", "Bank_Id", "dbo.BloodBanks", "Id");
        }
    }
}
