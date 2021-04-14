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
        #endregion

        #region Constructor
        public CountryService(ICountryRepository repository)
        {
            _repository = repository;
        }
        
        #endregion

        #region PublicMethods

        public Task<IEnumerable<CountryDTO>> GetAllCountries()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
