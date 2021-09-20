using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;//bu sonra silincek
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
   public interface IPersonalService:IService<PersonalViewModel>
    {
       Task AddWithPhoneNumbers(PersonalViewModel personal);
       List<PersonalDetailViewModel> GetPersonalDetails();
    }
}
