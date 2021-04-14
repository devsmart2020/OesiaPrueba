using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Interfaces
{
    public interface IBookRepository
    {
        Task<bool> CreateBook(TbBook book);
        Task<bool> DeleteBook(int id);
        Task<IEnumerable<BookList>> GetAllBooks();
        Task<TbBook> GetByIdBook(int id);
        Task<bool> UpdateBook(TbBook book);
    }
}
