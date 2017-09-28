using System.Data.Entity.Migrations;

namespace BloodManagmentSystem.Persistance.Migrations
{
    public partial class AddMockupDonorModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Donors", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Donors", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Donors", "Email", c => c.String());
            AlterColumn("dbo.Donors", "Name", c => c.String());
        }
    }
}
