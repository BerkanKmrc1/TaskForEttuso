using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Data.Context
{
    public class PersonalContext:DbContext
    {
        public PersonalContext(DbContextOptions<PersonalContext> options) : base(options)
        {

        }
    
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Phone> Phones { get; set; }

    }
}
