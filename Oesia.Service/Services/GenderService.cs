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
        #endregion

        #region Constructor
        public GenderService(IGenderRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region PublicMethods
        public Task<IEnumerable<GenderDTO>> GetAllGenders()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
