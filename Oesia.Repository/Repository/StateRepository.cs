using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;
using Oesia.Repository.Data;
using Oesia.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Repository
{
    public class StateRepository : IStateRepository
    {
        #region Members Variables
        private readonly db_oesiaContext _context;
        #endregion

        #region Constructor
        public StateRepository(db_oesiaContext context)
        {
            _context = context;
        }
        #endregion

        #region PublicMethods
        public async Task<IEnumerable<TbState>> GetAllStates()
        {
           return await _context.TbStates.FromSqlRaw("EXEC spr_getAllStates").ToListAsync();
        }
        #endregion
    }
}
