using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Domain.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<TbBook>> GetAuthors();
        Task<TbBook> GetByIdAuthor(TbBook author);
        Task<bool> CreatetAuthor(TbBook author);
        Task<bool> UpdateAuthor(TbBook author);
        Task<bool> DeleteAuthor(TbBook author);
    }
}
