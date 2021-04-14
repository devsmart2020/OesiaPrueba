using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;
using Oesia.Repository.Data;
using Oesia.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oesia.Repository.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        #region Members Variables
        private readonly db_oesiaContext _context;
        #endregion

        #region Constructor
        public AuthorRepository(db_oesiaContext context)
        {
            _context = context;
        }
        #endregion

        #region PublicMethods
        public async Task<bool> CreateAuthor(TbAuthor author)
        {
            var query = await _context.Database.ExecuteSqlRawAsync(Resources.SpInsertAuthor,
                  author.Name,
                  author.LastName,
                  author.Phone,
                  author.Email,
                  author.IdGender,
                  author.NumberBooks,
                  author.IdCity,
                  author.IdState,
                  author.IdCountry);
            return query > 0;
        }

        public async Task<bool> DeleteAuthor(int id)
        {
            var query = await _context.Database.ExecuteSqlRawAsync(Resources.SpDeleteAuthor, id);
            return query < 0;                   
        }

        public async Task<IEnumerable<AuthorList>> GetAllAuthors()
        {

            var query = await _context.TbAuthors.Select(x => new AuthorList
            {
                Author = $"{x.Name} {x.LastName}",
                Country = x.IdCityNavigation.IdStateNavigation.IdCountryNavigation.Name,
                Gender = x.IdGenderNavigation.Name,
                QuantityBooks = (int)x.NumberBooks
            }).ToListAsync();
            //var query = await _context.TbAuthors.FromSqlRaw("EXEC spr_getAllAuthor").ToListAsync();         
            return query;
        }

        public async Task<TbAuthor> GetByIdAuthor(int id)
        {
            var query = await _context.TbAuthors.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            return query;
        }

        public async Task<bool> UpdateAuthor(TbAuthor author)
        {
            var query = await _context.Database.ExecuteSqlRawAsync(Resources.SpUpdateAuthor,
                 author.Id,
                 author.Name,
                 author.LastName,
                 author.Phone,
                 author.Email,
                 author.IdGender,
                 author.NumberBooks,
                 author.IdCity,
                 author.IdState,
                 author.IdCountry);
            return query < 0;
        }
        #endregion
    }
}
