using Oesia.Front.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Interfaces
{
    public interface IAuthorService
    {
        Task<bool> CreateAuthor(AuthorDTO author, bool isNewItem);
        Task<bool> DeleteAuthor(int id);
        Task<IEnumerable<AuthorListDTO>> GetAllAuthors();
        Task<AuthorDTO> GetByIdAuthor(int id);
    }
}
