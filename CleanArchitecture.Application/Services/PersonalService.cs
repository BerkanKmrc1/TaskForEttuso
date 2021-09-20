using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModel;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class PersonalService : IPersonalService
    {
        private readonly IPersonalRepository _personalRepository = null;
        private readonly IMapper _mapper = null;
        public PersonalService(IPersonalRepository personalRepository, IMapper mapper)
        {
            _personalRepository = personalRepository;
            _mapper = mapper;
        }

        public async Task<bool> Add(PersonalViewModel personal)
        {
            personal.Phones = personal.SelectedPhones.Select(x => new PhoneViewModel { Id = x }).ToList();
            int id = await _personalRepository.Add(new Domain.Models.Personal 
            { 
                Name = personal.Name,
                Surname = personal.Surname,
                Email = personal.Email,
                BirthDay = personal.BirthDay,
                Phones = _mapper.Map<List<Phone>>(personal.Phones)
            });
            return id > 0;
        }

        public async Task AddWithPhoneNumbers(PersonalViewModel personal)
        {

            personal.Phones = personal.SelectedPhones.Select(x => new PhoneViewModel 
            { 
                Id = x 

            }).ToList();
            await _personalRepository.AddWithPhoneNumbers(_mapper.Map<Personal>(personal));
        }

        public int Delete(int id)
        {
            return _personalRepository.Delete(id);
        }

        public List<PersonalViewModel> GetAll()
        {
            return _mapper.Map<List<PersonalViewModel>>(_personalRepository.GetAll());
        }

        public PersonalViewModel GetById(int id)
        {
           return _mapper.Map<PersonalViewModel>(_personalRepository.GetById(id));
        }

        public List<PersonalDetailViewModel> GetPersonalDetails()
        {
            return _personalRepository.GetPersonalDetails();
        }

        public int Update(PersonalViewModel entity)
        {
            return _personalRepository.Update(_mapper.Map<Personal>(entity));
        }
    }
}
