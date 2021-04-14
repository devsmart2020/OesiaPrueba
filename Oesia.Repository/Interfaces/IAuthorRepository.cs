using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Interfaces
{
    public interface IAuthorRepository
    {
        Task<bool> CreateAuthor(TbAuthor author);
        Task<bool> DeleteAuthor(int id);
        Task<IEnumerable<AuthorList>> GetAllAuthors();
        Task<TbAuthor> GetByIdAuthor(int id);
        Task<bool> UpdateAuthor(TbAuthor author);

    }
}
