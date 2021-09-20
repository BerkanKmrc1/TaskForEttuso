using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CleanArchitecture.Domain.Models
{
    public class Personal:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }
        public virtual List<Phone> Phones { get; set; }


    }
}