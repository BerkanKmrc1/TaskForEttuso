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
    public class PhoneService : IPhoneService
    {
        private readonly IPhoneRepository _phoneRepository = null;
        private readonly IMapper _mapper = null;
        public PhoneService(IPhoneRepository phoneRepository,IMapper mapper)
        {
            _phoneRepository = phoneRepository;
            _mapper = mapper;
        }

        public async Task<bool> Add(PhoneViewModel entity)
        {
            int i = await _phoneRepository.Add(new Domain.Models.Phone
            {
                PhoneNumber = entity.PhoneNumber
            });
            return i > 0;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PhoneViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<List<PhoneViewModel>>(_phoneRepository.GetAll());
                
            }
            catch (Exception e)
            {
                return _mapper.Map<List<PhoneViewModel>>(_phoneRepository.GetAll());
            }
            
        }

        public PhoneViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(PhoneViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
