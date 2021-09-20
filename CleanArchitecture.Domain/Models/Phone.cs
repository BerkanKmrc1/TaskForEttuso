using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CleanArchitecture.Domain.Models
{
    public class Phone:Entity
    {
        public string PhoneNumber { get; set; }
        public virtual Personal Personal { get; set; }
    }
}