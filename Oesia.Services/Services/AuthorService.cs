using AutoMapper;
using Oesia.Domain.DTOs;
using Oesia.Domain.Entities;
using Oesia.Domain.Interfaces;
using Oesia.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Services
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

        #region Public Methods
        public async Task<bool> CreatetAuthor(AuthorDTO author)
        {
            if (author != null)
            {
                TbAuthor tbAuthor = _mapper.Map<TbAuthor>(author);
                var query = _mapper.Map<AuthorDTO>(await _repository.CreatetAuthor(tbAuthor));
                return query != null;
            }
            else            
                return false;            
        }

        public Task<bool> DeleteAuthor(AuthorDTO author)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuthorDTO>> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDTO> GetByIdAuthor(AuthorDTO author)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAuthor(AuthorDTO author)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
