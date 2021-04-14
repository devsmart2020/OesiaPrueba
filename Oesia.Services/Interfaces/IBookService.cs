using Oesia.Domain.DTOs;
using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDTO>> GetAuthors();
        Task<BookDTO> GetByIdAuthor(TbBook author);
        Task<bool> CreatetAuthor(TbBook author);
        Task<bool> UpdateAuthor(TbBook author);
        Task<bool> DeleteAuthor(TbBook author);
    }
}
