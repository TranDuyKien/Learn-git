using HR_Management.Services.CategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; } 
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        public string UpdatedBy { get; set; }
        public virtual ICollection<Technology> Technologies { get; set; }
    }
}
