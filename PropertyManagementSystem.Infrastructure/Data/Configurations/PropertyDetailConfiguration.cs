using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManagementSystem.Domain.Entities;

namespace PropertyManagementSystem.Infrastructure.Data.Configurations
{
    public class PropertyDetailConfiguration : IEntityTypeConfiguration<PropertyDetail>
    {
        public void Configure(EntityTypeBuilder<PropertyDetail> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(e => e.TotalRooms).IsRequired();
            builder.Property(e => e.Size).IsRequired();

            builder.HasOne(p => p.Property)
                .WithOne(p => p.PropertyDetails)
                .HasForeignKey<PropertyDetail>(p => p.PropertyId);
            builder.HasMany(p => p.Images)
                .WithOne(p => p.PropertyDetail);

        }

    }
}

