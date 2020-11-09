using HR_Management.Context.Configurations;
using HR_Management.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("HRManagement");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CertificateConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new PersonTechnologyConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectTechnologyConfiguration());
            modelBuilder.ApplyConfiguration(new TechnologyConfiguration());
            modelBuilder.ApplyConfiguration(new WorkHistoryConfiguration());
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonTechnology> PersonMapTechnologies { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectTechnology> ProjectMapTechnologies { get; set; }
        public virtual DbSet<Technology> Technologies { get; set; }
        public virtual DbSet<WorkHistory> WorkHistories { get; set; }
    }
}
