using AutoMapper;
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
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public EditorialService(IEditorialRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region PublicMethods
        public async Task<IEnumerable<EditorialDTO>> GetAllEditorials()
        {
            return _mapper.Map<IEnumerable<EditorialDTO>>(await _repository.GetAllEditorials());

        }
        #endregion
    }
}
