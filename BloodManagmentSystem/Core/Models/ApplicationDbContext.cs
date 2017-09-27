using BloodManagmentSystem.Persistance.EntityConfigurations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BloodManagmentSystem.Core.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BloodRequest> Requests { get; set; }
        public DbSet<BloodBank> Banks { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BloodRequestConfiguration());
            modelBuilder.Configurations.Add(new BloodBankConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}