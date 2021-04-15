using Oesia.App.Models.DTOs;
using Oesia.App.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.App.Service.Services
{
    public class BookService : IBookService
    {

        #region Members Variables
       
        #endregion

        #region PublicMethods
        public Task<bool> CreateBook(BookDTO book)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<BookListDTO>> GetAllBooks()
        {
            throw new System.NotImplementedException();
        }

        public Task<BookDTO> GetByIdBook(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateBook(BookDTO book)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
