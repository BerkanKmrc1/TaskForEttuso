using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IPersonalRepository: IRepository<Personal>
    {
        Task AddWithPhoneNumbers(Personal personal);

        List<PersonalDetailViewModel> GetPersonalDetails();

    }
}
