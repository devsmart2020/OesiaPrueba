using Microsoft.EntityFrameworkCore;
using Oesia.Domain.Entities;
using Oesia.Repository.Data;
using Oesia.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oesia.Repository.Repository
{
    public class BookRepository : IBookRepository
    {
        #region Members Variables
        private readonly db_oesiaContext _context;
        #endregion

        #region Constructor
        public BookRepository(db_oesiaContext context)
        {
            _context = context;
        }
        #endregion

        #region PublicMethods
        public async Task<bool> CreateBook(TbBook book)
        {
            var query = await _context.Database.ExecuteSqlRawAsync(Resources.SpInsertBook,
                  book.Name,
                  book.WriteDate,
                  book.LaunchDate,
                  book.Price,
                  book.IdAuthor,
                  book.IdEditorial,
                  book.Remarks);
            return query < 0;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var query = await _context.Database.ExecuteSqlRawAsync(Resources.SpDeleteBook, id);
            return query < 0;
        }

        public async Task<IEnumerable<BookList>> GetAllBooks()
        {
            var query = await _context.TbBooks.Select(x => new BookList
            {
                Book = x.Name,
                DateWrite = x.WriteDate.ToShortDateString(),
                Price = x.Price,
                Author = $"{x.IdAuthorNavigation.Name} {x.IdAuthorNavigation.LastName}",
            }).ToListAsync();
            //var query = await _context.TbBooks.FromSqlRaw("EXEC spr_getAllBook").ToListAsync();         
            return query;
        }

        public async Task<TbBook> GetByIdBook(int id)
        {
            var query = await _context.TbBooks.Where(x => x.Id.Equals(id)).FirstOrDefaultAsync();
            return query;
        }

        public async Task<bool> UpdateBook(TbBook book)
        {
            var query = await _context.Database.ExecuteSqlRawAsync(Resources.SpUpdateBook,
                 book.Id,
                  book.Name,
                  book.WriteDate,
                  book.LaunchDate,
                  book.Price,
                  book.IdAuthor,
                  book.IdEditorial,
                  book.Remarks);
            return query < 0;
        }
        #endregion
    }
}
