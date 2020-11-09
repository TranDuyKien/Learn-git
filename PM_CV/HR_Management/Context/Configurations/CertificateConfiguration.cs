using HR_Management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Context.Configurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.ToTable("Certificate");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
            builder.Property(x => x.OrderIndex).IsRequired();
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.Provider).IsRequired().HasMaxLength(256);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.StartDate).IsRequired();
            builder.HasOne(x => x.Person).WithMany(x => x.Certificates).HasForeignKey(x => x.PersonId);
        }
    }
}
