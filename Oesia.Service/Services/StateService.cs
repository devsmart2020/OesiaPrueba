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
        #endregion

        #region Constructor
        public StateService(IStateRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region PublicMethods
        public Task<IEnumerable<StateDTO>> GetAllStates()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
