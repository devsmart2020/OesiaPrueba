using System;

namespace Oesia.App.Models.DTOs
{
    public class BookListDTO
    {
        public string Book { get; set; }
        public DateTime DateWrite { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
