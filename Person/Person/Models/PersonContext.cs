using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.Models
{
    public class PersonContext:DbContext
    {
        public PersonContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
