using System.Data.Entity.Migrations;

namespace BloodManagmentSystem.Persistance.Migrations
{
    public partial class AddBloodRequestAndBloodBank : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodBanks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BloodRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BloodType = c.Int(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        City = c.String(),
                        Bank_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BloodBanks", t => t.Bank_Id)
                .Index(t => t.Bank_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BloodRequests", "Bank_Id", "dbo.BloodBanks");
            DropIndex("dbo.BloodRequests", new[] { "Bank_Id" });
            DropTable("dbo.BloodRequests");
            DropTable("dbo.BloodBanks");
        }
    }
}
