using System;
using System.Collections.Generic;

namespace HR_Management.Entities
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<PersonTechnology> PersonTechnologies { get; set; }
        public ICollection<ProjectTechnology> ProjectTechnologies { get; set; }

    }
}
