using HR_Management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Context.Configurations
{
    public class PersonTechnologyConfiguration : IEntityTypeConfiguration<PersonTechnology>
    {
        public void Configure(EntityTypeBuilder<PersonTechnology> builder)
        {
            builder.ToTable("PersonTechnology");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(true);
            builder.HasOne(x => x.Person).WithMany(x => x.PersonTechnologies).HasForeignKey(x => x.PersonId);
            builder.HasOne(x => x.Technology).WithMany(x => x.PersonTechnologies).HasForeignKey(x => x.TechnologyId);
        }
    }
}
