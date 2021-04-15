using Oesia.Front.Models.DTOs;
using Oesia.Front.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Services
{
    public class GenderService : IGenderService
    {

        #region Members Variables

        #endregion

        #region Constructor
        public GenderService()
        {

        }
        #endregion

        #region PublicMethods
        public Task<IEnumerable<GenderDTO>> GetAllGenders()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
