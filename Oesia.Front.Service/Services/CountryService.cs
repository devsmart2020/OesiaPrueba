using Oesia.Front.Models.DTOs;
using Oesia.Front.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Services
{
    public class CountryService : ICountryService
    {

        #region Members Variables

        #endregion

        #region Constructor
        public CountryService()
        {

        }

        #endregion

        #region PublicMethods

        public Task<IEnumerable<CountryDTO>> GetAllCountries()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
