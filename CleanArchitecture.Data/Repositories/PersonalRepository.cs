using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Data.Context;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Data.Repositories
{
    public class PersonalRepository:Repository<Personal>,IPersonalRepository
    {
        public PersonalRepository(PersonalContext context) : base(context)
        {

        }
        public async Task AddWithPhoneNumbers(Personal personal)
        {
            _context.Phones.AttachRange(personal.Phones);

            await base.Add(personal);

        }

        public List<PersonalDetailViewModel> GetPersonalDetails()
        {
            var result = from p in _context.Personals
                         join b in _context.Phones
                         on p.Id equals b.Id
                         select new PersonalDetailViewModel
                         {
                             Name = p.Name,
                             Surname = p.Surname,
                             Email = p.Email,
                             BirthDay = p.BirthDay,
                             PhoneNumber = b.PhoneNumber,
                             Id=p.Id
                         };
            return result.ToList();
                      

        }
    }
}
