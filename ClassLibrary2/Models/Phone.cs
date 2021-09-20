using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskForEttuso.Models
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        public string PhoneNo { get; set; }
        public int PersonalId { get; set; }
        public virtual Personal Personal { get; set; }
    }
}