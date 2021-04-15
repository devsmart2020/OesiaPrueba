using Oesia.App.Models.DTOs;
using Oesia.App.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.App.Service.Services
{
    public class CityService : ICityService
    {

        #region Members Variables

        #endregion

        #region Constructor
        public CityService()
        {

        }
        #endregion

        #region PublicMethods
        public Task<IEnumerable<CityDTO>> GetAllCities()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
