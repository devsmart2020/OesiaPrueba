using Oesia.Front.Models.DTOs;
using Oesia.Front.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Services
{
    public class StateService : IStateService
    {

        #region Members Variables

        #endregion

        #region Constructor
        public StateService()
        {

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
