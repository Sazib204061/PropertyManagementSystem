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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {


        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a=>a.UserName).IsRequired().HasMaxLength(50);
            builder.Property(a => a.UserEmail).IsRequired().HasMaxLength(50);
            builder.Property(a => a.UserPhone).IsRequired().HasMaxLength(15);


        }
    }
}