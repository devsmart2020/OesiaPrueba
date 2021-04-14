using Oesia.Infrastructure.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Interfaces
{
    public interface IAuthorService
    {
        Task<bool> CreateAuthor(AuthorDTO author);
        Task<bool> DeleteAuthor(int id);
        Task<IEnumerable<AuthorListDTO>> GetAllAuthors();
        Task<AuthorDTO> GetByIdAuthor(int id);
        Task<bool> UpdateAuthor(AuthorDTO author);
    }
}
