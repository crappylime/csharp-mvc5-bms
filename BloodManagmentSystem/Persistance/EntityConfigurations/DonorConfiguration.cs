using BloodManagmentSystem.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace BloodManagmentSystem.Persistance.EntityConfigurations
{
    public class DonorConfiguration : EntityTypeConfiguration<Donor>
    {
        public DonorConfiguration()
        {
            Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(d => d.Email)
                .IsRequired();

            Property(d => d.BloodType)
                .IsRequired();
        }
    }
}