using AutoMapper;
using Oesia.Domain.Entities;
using Oesia.Infrastructure.DTOs;
using Oesia.Repository.Interfaces;
using Oesia.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Services
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

        #region PublicMethods
        public async Task<bool> CreateBook(BookDTO book)
        {
            TbBook tbBook = _mapper.Map<TbBook>(book);
            return await _repository.CreateBook(tbBook);
        }

        public async Task<bool> DeleteBook(int id)
        {
            return await _repository.DeleteBook(id);
        }

        public async Task<IEnumerable<BookListDTO>> GetAllBooks()
        {
            return _mapper.Map<IEnumerable<BookListDTO>>(await _repository.GetAllBooks());
        }

        public async Task<BookDTO> GetByIdBook(int id)
        {
            return _mapper.Map<BookDTO>(await _repository.GetByIdBook(id));
        }

        public async Task<bool> UpdateBook(BookDTO book)
        {
            TbBook tbBook = _mapper.Map<TbBook>(book);
            return await _repository.UpdateBook(tbBook);
        }
        #endregion
    }
}
