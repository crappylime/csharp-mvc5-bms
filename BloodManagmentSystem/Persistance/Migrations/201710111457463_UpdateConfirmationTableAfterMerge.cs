namespace BloodManagmentSystem.Persistance.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdateConfirmationTableAfterMerge : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Confirmations",
                c => new
                    {
                        RequestId = c.Int(nullable: false),
                        DonorId = c.Int(nullable: false),
                        HashCode = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.RequestId, t.DonorId })
                .ForeignKey("dbo.Donors", t => t.DonorId, cascadeDelete: true)
                .ForeignKey("dbo.BloodRequests", t => t.RequestId, cascadeDelete: true)
                .Index(t => t.RequestId)
                .Index(t => t.DonorId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Confirmations", "RequestId", "dbo.BloodRequests");
            DropForeignKey("dbo.Confirmations", "DonorId", "dbo.Donors");
            DropIndex("dbo.Confirmations", new[] { "DonorId" });
            DropIndex("dbo.Confirmations", new[] { "RequestId" });
            DropTable("dbo.Confirmations");
        }
    }
}
