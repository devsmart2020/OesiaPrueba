using AutoMapper;
using Oesia.Infrastructure.DTOs;
using Oesia.Repository.Interfaces;
using Oesia.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Services
{
    public class GenderService : IGenderService
    {

        #region Members Variables
        private readonly IGenderRepository _repository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GenderService(IGenderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region PublicMethods
        public async Task<IEnumerable<GenderDTO>> GetAllGenders()
        {
            return _mapper.Map<IEnumerable<GenderDTO>>(await _repository.GetAllGenders());
        }
        #endregion
    }
}
