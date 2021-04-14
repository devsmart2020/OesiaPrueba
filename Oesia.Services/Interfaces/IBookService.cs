using Oesia.Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDTO>> GetAuthors();
        Task<BookDTO> GetByIdAuthor(BookDTO author);
        Task<bool> CreatetAuthor(BookDTO author);
        Task<bool> UpdateAuthor(BookDTO author);
        Task<bool> DeleteAuthor(BookDTO author);
    }
}
