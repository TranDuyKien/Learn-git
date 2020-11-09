using HR_Management.Infrastructure;
using System;
using System.Collections.Generic;

namespace HR_Management.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string StaffId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public eLocation Location { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public DateTime? YearOfBirth { get; set; }
        public eGender Gender { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        public string UpdatedBy { get; set; }
        public virtual ICollection<PersonTechnology> PersonTechnologies { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<WorkHistory> WorkHistories { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<Project> Projects { get; set; }

    }
}
