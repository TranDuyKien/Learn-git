using System;
using System.Collections.Generic;

namespace HR_Management.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }
        public int TeamSize { get; set; }
        public int OrderIndex { get; set; }
        public bool Status { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CreatedAt { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        public string UpdatedBy { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public virtual ICollection<ProjectTechnology> ProjectTechnologies { get; set; }

    }
}
