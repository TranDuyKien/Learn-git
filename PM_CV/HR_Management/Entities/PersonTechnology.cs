using System;

namespace HR_Management.Entities
{
    public class PersonTechnology
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }

    }
}
