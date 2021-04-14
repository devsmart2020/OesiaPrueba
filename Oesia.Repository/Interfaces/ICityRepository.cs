using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Interfaces
{
    public interface ICityRepository
    {
        Task<IEnumerable<TbCity>> GetAllCities();
    }
}
