using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models
{
    public class IEntity
    {
        int Id { get; set; }
    }
    public class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
