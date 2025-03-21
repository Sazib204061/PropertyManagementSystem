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
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {


        public void Configure(EntityTypeBuilder<Owner> builder)
        {

            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name).IsRequired().HasMaxLength(50);
            builder.Property(o => o.ContactNumber).HasMaxLength(15);
            builder.Property(o => o.Email).IsRequired().HasMaxLength(50);

        }
    }
}
