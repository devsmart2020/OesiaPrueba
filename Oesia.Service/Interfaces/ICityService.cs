using Oesia.Infrastructure.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Service.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDTO>> GetAllCities();

    }
}
