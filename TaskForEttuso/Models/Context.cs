using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskForEttuso.Models
{
    public class Context:DbContext
    {

        public DbSet<Personal> Personals { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}