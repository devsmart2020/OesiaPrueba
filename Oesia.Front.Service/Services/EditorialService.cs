using Oesia.Front.Models.DTOs;
using Oesia.Front.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Front.Service.Services
{
    public class EditorialService : IEditorialService
    {

        #region Members Variables
        
        #endregion

        #region Constructor
        public EditorialService()
        {
           
        }
        #endregion

        #region PublicMethods
        public Task<IEnumerable<EditorialDTO>> GetAllEditorials()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
