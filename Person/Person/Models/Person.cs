using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Person.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StaffId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Location { get; set; }
        public string Avatar { get; set; }
        public string Decription { get; set; }
        public string Phone { get; set; }
        public DateTime YearOfBirth { get; set; }
        public int Gender { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool Status { get; set; }
    }
}
