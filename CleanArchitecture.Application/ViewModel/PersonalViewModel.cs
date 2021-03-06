using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModel
{
    public class PersonalViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PhoneViewModel> Phones { get; set; }
        public List<int> SelectedPhones { get; set; }
        public string Surname { get; set; }
        public string BirthDay { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
    }
}
