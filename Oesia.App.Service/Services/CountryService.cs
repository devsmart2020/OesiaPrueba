using Oesia.App.Models.DTOs;
using Oesia.App.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.App.Service.Services
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
