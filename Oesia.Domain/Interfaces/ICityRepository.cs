using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Domain.Interfaces
{
    public interface ICityRepository
    {
        Task<IEnumerable<TbCity>> GetCities();
    }
}
