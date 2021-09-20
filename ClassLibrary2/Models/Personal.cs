using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskForEttuso.Models
{
    public class Personal
    {
        [Key]
        public int PersonalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDay { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }

    }
}