using AutoMapper;
using Oesia.Domain.DTOs;
using Oesia.Domain.Interfaces;
using Oesia.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Services
{
    public class BookService : IBookService
    {
        #region Members Variables
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public BookService(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region Public Methods
        public Task<bool> CreatetAuthor(BookDTO author)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAuthor(BookDTO author)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BookDTO>> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public Task<BookDTO> GetByIdAuthor(BookDTO author)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAuthor(BookDTO author)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
