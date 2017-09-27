using BloodManagmentSystem.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace BloodManagmentSystem.Persistance.EntityConfigurations
{
    public class BloodBankConfiguration : EntityTypeConfiguration<BloodBank>
    {
        public BloodBankConfiguration()
        {
            Property(bb => bb.Name)
                .IsRequired()
                .HasMaxLength(255);

            Property(bb => bb.City)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}