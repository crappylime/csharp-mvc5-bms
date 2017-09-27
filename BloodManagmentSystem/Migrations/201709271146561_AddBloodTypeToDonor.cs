namespace BloodManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
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
