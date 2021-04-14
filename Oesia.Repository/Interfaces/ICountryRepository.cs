using Oesia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Interfaces
{
    public interface ICountryRepository
    {
        Task<IEnumerable<TbCountry>> GetAllCountries();

    }
}
