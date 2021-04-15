using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;
using Oesia.Repository.Data;
using Oesia.Repository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oesia.Repository.Repository
{
    public class CountryRepository : ICountryRepository
    {
        #region Members Variables
        private readonly db_oesiaContext _context;
        #endregion

        #region Constructor
        public CountryRepository(db_oesiaContext context)
        {
            _context = context;
        }


        #endregion

        #region Public Methods
        public async Task<IEnumerable<TbCountry>> GetAllCountries()
        {
           return await _context.TbCountries.FromSqlRaw("EXEC spr_getAllCountries").ToListAsync();   
        }
        #endregion
    }
}
