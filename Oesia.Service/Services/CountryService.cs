using AutoMapper;
using Oesia.Infrastructure.DTOs;
using Oesia.Repository.Interfaces;
using Oesia.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Services
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

        #region PublicMethods

        public async Task<IEnumerable<CountryDTO>> GetAllCountries()
        {
            return _mapper.Map<IEnumerable<CountryDTO>>(await _repository.GetAllCountries());
        }
        #endregion
    }
}
