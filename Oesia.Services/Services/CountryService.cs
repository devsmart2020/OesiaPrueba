using AutoMapper;
using Oesia.Domain.DTOs;
using Oesia.Domain.Interfaces;
using Oesia.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Services
{
    public class CountryService : ICountryService
    {
        #region Members Variables
        private readonly ICountryRepository _repository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CountryService(ICountryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region Public Methods
        public Task<IEnumerable<CountryDTO>> GetCountries()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
