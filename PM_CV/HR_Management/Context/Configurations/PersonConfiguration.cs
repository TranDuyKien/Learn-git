using HR_Management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Context.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.StaffId).IsRequired();
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Avatar).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Email).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.YearOfBirth);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
        }
    }
}
