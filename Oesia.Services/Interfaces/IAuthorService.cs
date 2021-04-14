using Oesia.Domain.DTOs;
using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAuthors();
        Task<AuthorDTO> GetByIdAuthor(TbAuthor author);
        Task<bool> CreatetAuthor(TbAuthor author);
        Task<bool> UpdateAuthor(TbAuthor author);
        Task<bool> DeleteAuthor(TbAuthor author);
    }
}
