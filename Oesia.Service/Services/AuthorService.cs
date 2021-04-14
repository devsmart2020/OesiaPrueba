using AutoMapper;
using Oesia.Domain.Entities;
using Oesia.Infrastructure.DTOs;
using Oesia.Repository.Interfaces;
using Oesia.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Services
{
    public class AuthorService : IAuthorService
    {
        #region Members Variables
        private readonly IAuthorRepository _repository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public AuthorService(IAuthorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        #endregion

        #region PublicMethods
        public async Task<bool> CreateAuthor(AuthorDTO author)
        {
            TbAuthor tbAuthor = _mapper.Map<TbAuthor>(author);
            return await _repository.CreateAuthor(tbAuthor);
        }

        public async Task<bool> DeleteAuthor(int id)
        {

            return await _repository.DeleteAuthor(id);
        }

        public async Task<IEnumerable<AuthorListDTO>> GetAllAuthors()
        {
            return _mapper.Map<IEnumerable<AuthorListDTO>>(await _repository.GetAllAuthors());
        }

        public async Task<AuthorDTO> GetByIdAuthor(int id)
        {
            return _mapper.Map<AuthorDTO>(await _repository.GetByIdAuthor(id));
        }

        public async Task<bool> UpdateAuthor(AuthorDTO author)
        {
            TbAuthor tbAuthor = _mapper.Map<TbAuthor>(author);
            return await _repository.UpdateAuthor(tbAuthor);
        }
        #endregion
    }
}
