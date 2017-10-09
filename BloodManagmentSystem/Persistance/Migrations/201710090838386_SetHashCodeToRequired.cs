namespace BloodManagmentSystem.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetHashCodeToRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Confirmations", "HashCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Confirmations", "HashCode", c => c.String());
        }
    }
}
