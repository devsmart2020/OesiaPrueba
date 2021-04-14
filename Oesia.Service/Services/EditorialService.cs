using Oesia.Infrastructure.DTOs;
using Oesia.Repository.Interfaces;
using Oesia.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Services
{
    public class EditorialService : IEditorialService
    {

        #region Members Variables
        private readonly IEditorialRepository _repository;
        #endregion

        #region Constructor
        public EditorialService(IEditorialRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region PublicMethods
        public Task<IEnumerable<EditorialDTO>> GetAllEditorials()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
