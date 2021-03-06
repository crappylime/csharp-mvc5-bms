﻿using BloodManagmentSystem.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace BloodManagmentSystem.Persistance.EntityConfigurations
{
    public class DonorConfiguration : EntityTypeConfiguration<Donor>
    {
        public DonorConfiguration()
        {
            Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(d => d.Email)
                .IsRequired()
                .HasMaxLength(255);

            Property(d => d.City)
                .IsRequired()
                .HasMaxLength(50);

            Property(d => d.BloodType)
                .IsRequired();
        }
    }
}