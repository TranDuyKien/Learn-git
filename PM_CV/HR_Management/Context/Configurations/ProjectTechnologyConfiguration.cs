using HR_Management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Context.Configurations
{
    public class ProjectTechnologyConfiguration : IEntityTypeConfiguration<ProjectTechnology>
    {
        public void Configure(EntityTypeBuilder<ProjectTechnology> builder)
        {
            builder.ToTable("ProjectTechnology");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.Project).WithMany(x => x.ProjectTechnologies).HasForeignKey(x => x.ProjectId);
            builder.HasOne(x => x.Technology).WithMany(x => x.ProjectTechnologies).HasForeignKey(x => x.TechnologyId);
        }
    }
}
