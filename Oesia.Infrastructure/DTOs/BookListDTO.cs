using System;

namespace Oesia.Infrastructure.DTOs
{
    public class BookListDTO
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public DateTime DateWrite { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
