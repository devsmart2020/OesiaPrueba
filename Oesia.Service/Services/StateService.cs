using AutoMapper;
using Oesia.Infrastructure.DTOs;
using Oesia.Repository.Interfaces;
using Oesia.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Services
{
    public class StateService : IStateService
    {

        #region Members Variables
        private readonly IStateRepository _repository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public StateService(IStateRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region PublicMethods
        public async Task<IEnumerable<StateDTO>> GetAllStates()
        {
            return _mapper.Map<IEnumerable<StateDTO>>(await _repository.GetAllStates());
        }
        #endregion
    }
}
