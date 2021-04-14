using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Domain.Interfaces
{
    public interface ICountryRepository
    {
        Task<IEnumerable<TbCountry>> GetCountries();
    }
}
