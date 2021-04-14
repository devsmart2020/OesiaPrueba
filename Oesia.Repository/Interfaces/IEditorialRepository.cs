using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Interfaces
{
    public interface IEditorialRepository
    {
        Task<IEnumerable<TbEditorial>> GetAllEditorials();

    }
}
