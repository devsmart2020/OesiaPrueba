using Oesia.App.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.App.Service.Interfaces
{
    public interface IBookService
    {
        Task<bool> CreateBook(BookDTO book);
        Task<bool> DeleteBook(int id);
        Task<IEnumerable<BookListDTO>> GetAllBooks();
        Task<BookDTO> GetByIdBook(int id);
        Task<bool> UpdateBook(BookDTO book);
    }
}
