using HR_Management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Context.Configurations
{
    public class WorkHistoryConfiguration : IEntityTypeConfiguration<WorkHistory>
    {
        public void Configure(EntityTypeBuilder<WorkHistory> builder)
        {
            builder.ToTable("WorkHistory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Position).IsRequired().HasMaxLength(256);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(256);
            builder.Property(x => x.OrderIndex).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.StartDate).IsRequired();
            builder.HasOne(x => x.Person).WithMany(x => x.WorkHistories).HasForeignKey(x => x.PersonId);
        }
    }
}
