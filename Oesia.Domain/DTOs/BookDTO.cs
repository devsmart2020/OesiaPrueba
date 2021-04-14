using System;

#nullable disable

namespace Oesia.Domain.DTOs
{
    public partial class BookDTO
    {
        public int IdBook { get; set; }
        public string Name { get; set; }
        public DateTime WriteDate { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }

        public AuthorDTO Author { get; set; }
    }
}
