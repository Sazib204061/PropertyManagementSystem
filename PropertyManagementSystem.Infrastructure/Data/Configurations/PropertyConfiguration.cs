using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Domain.Entities;

namespace PropertyManagementSystem.Infrastructure.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        

        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);


            builder.HasOne(p => p.Owner)
                .WithMany(o => o.Properties)
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Appointments)
                .WithOne(a => a.Property)
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
