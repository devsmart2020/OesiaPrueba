using Oesia.Infrastructure.DTOs;
using Oesia.Repository.Interfaces;
using Oesia.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Services
{
    public class CityService : ICityService
    {

        #region Members Variables
        private readonly ICityRepository _repository;
        #endregion

        #region Constructor
        public CityService(ICityRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region PublicMethods
        public Task<IEnumerable<CityDTO>> GetAllCities()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
