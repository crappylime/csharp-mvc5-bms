using System.Data.Entity.Migrations;
using BloodManagmentSystem.Core.Models;

namespace BloodManagmentSystem.Persistance.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BloodManagmentSystem.Core.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Persistance\Migrations";
        }

        protected override void Seed(BloodManagmentSystem.Core.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Banks.AddOrUpdate(
                b => new { b.Name, b.City }, 
                new BloodBank { Name = "RCKiK Kraków", City = "Kraków"},
                new BloodBank { Name = "RCK Warszawa", City = "Warszawa"},
                new BloodBank { Name = "RCK Katowice", City = "Katowice"}
            );
        }
    }
}
