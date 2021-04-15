using AutoMapper;
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
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public CityService(ICityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region PublicMethods
        public async Task<IEnumerable<CityDTO>> GetAllCities()
        {
            return _mapper.Map<IEnumerable<CityDTO>>(await _repository.GetAllCities());
        }
        #endregion
    }
}
