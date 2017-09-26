using System.Data.Entity.Migrations;

namespace BloodManagmentSystem.Persistance.Migrations
{
    public partial class PopulateDBWithBloodBankExemple : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BloodBanks (Name, City) VALUES ('RCK Krakow', 'Cracow')");
            Sql("INSERT INTO BloodBanks (Name, City) VALUES ('RCK Katowice', 'Katowice')");
            Sql("INSERT INTO BloodBanks (Name, City) VALUES ('RCK Warszawa', 'Warsow')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM BloodBanks WHERE Id IN (1, 2, 3)");
        }
    }
}
