using BloodManagmentSystem.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace BloodManagmentSystem.Persistance.EntityConfigurations
{
    public class BloodRequestConfiguration : EntityTypeConfiguration<BloodRequest>
    {
        public BloodRequestConfiguration()
        {
            Property(br => br.BloodType)
                .IsRequired();

            Property(br => br.DueDate)
                .IsRequired();

            Property(br => br.City)
                .HasMaxLength(50);

            Property(br => br.BankId)
                .IsRequired();
        }
    }
}