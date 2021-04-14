using Oesia.Domain.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorDTO>> GetAuthors();
        Task<AuthorDTO> GetByIdAuthor(AuthorDTO author);
        Task<bool> CreatetAuthor(AuthorDTO author);
        Task<bool> UpdateAuthor(AuthorDTO author);
        Task<bool> DeleteAuthor(AuthorDTO author);
    }
}
