using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;
using Oesia.Repository.Data;
using Oesia.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Repository
{
    public class EditorialRepository : IEditorialRepository
    {
        #region Members Variables
        private readonly db_oesiaContext _context;
        #endregion

        #region Constructor
        public EditorialRepository(db_oesiaContext context)
        {
            _context = context;
        }


        #endregion

        #region PublicMethods
        public async Task<IEnumerable<TbEditorial>> GetAllEditorials()
        {
            return await _context.TbEditorials.FromSqlRaw("EXEC spr_getAllEditorials").ToListAsync();

        }
        #endregion
    }
}
