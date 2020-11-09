using HR_Management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Context.Configurations
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Education");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CollegeName).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Major).IsRequired().HasMaxLength(256);
            builder.Property(x => x.OrderIndex).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.StartDate).IsRequired();
            builder.HasOne(x => x.Person).WithMany(x => x.Educations).HasForeignKey(x => x.PersonId);
        }
    }
}
