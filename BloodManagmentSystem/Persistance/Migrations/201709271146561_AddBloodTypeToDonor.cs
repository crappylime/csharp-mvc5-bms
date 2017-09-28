using System.Data.Entity.Migrations;

namespace BloodManagmentSystem.Persistance.Migrations
{
    public partial class AddBloodTypeToDonor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donors", "BloodType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Donors", "BloodType");
        }
    }
}
