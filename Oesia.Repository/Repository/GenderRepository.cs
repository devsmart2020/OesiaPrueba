using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;
using Oesia.Repository.Data;
using Oesia.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Repository
{
    public class GenderRepository : IGenderRepository
    {
        #region Members Variables
        private readonly db_oesiaContext _context;
        #endregion

        #region Constructor
        public GenderRepository(db_oesiaContext context)
        {
            _context = context;
        }

        #endregion

        #region PublicMethods

        public async Task<IEnumerable<TbGender>> GetAllGenders()
        {
            return await _context.TbGenders.FromSqlRaw("EXEC spr_getAllGenders").ToListAsync();

        }
        #endregion
    }
}
