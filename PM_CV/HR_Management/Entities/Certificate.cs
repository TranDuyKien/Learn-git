using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Entities
{
    public class Certificate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Provider { get; set; }
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
    }
}
