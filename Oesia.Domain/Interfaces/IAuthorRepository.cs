using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Domain.Interfaces
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<TbAuthor>> GetAuthors();
        Task<TbAuthor> GetByIdAuthor(TbAuthor author);
        Task<bool> CreatetAuthor(TbAuthor author);
        Task<bool> UpdateAuthor(TbAuthor author);
        Task<bool> DeleteAuthor(TbAuthor author);
    }
}
