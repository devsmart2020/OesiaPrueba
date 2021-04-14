using AutoMapper;
using Oesia.Domain.DTOs;
using Oesia.Domain.Interfaces;
using Oesia.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Services
{
    public class CityService : ICityService
    {
        #region Members Variables
        private readonly ICityRepository _repository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CityService(ICityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region Public Methods
        public Task<IEnumerable<CityDTO>> GetCountries()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
