using System.Data.Entity.Migrations;

namespace BloodManagmentSystem.Persistance.Migrations
{
    public partial class AddDataAnnotationsForBloodBankAndBloodRequest : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Requests", "Bank_Id", "dbo.Banks");
            DropIndex("dbo.Requests", new[] { "Bank_Id" });
            AlterColumn("dbo.Banks", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Banks", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Requests", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.Requests", "Bank_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Requests", "Bank_Id");
            AddForeignKey("dbo.Requests", "Bank_Id", "dbo.Banks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requests", "Bank_Id", "dbo.Banks");
            DropIndex("dbo.Requests", new[] { "Bank_Id" });
            AlterColumn("dbo.Requests", "Bank_Id", c => c.Int());
            AlterColumn("dbo.Requests", "City", c => c.String());
            AlterColumn("dbo.Banks", "City", c => c.String());
            AlterColumn("dbo.Banks", "Name", c => c.String());
            CreateIndex("dbo.Requests", "Bank_Id");
            AddForeignKey("dbo.Requests", "Bank_Id", "dbo.Banks", "Id");
        }
    }
}
