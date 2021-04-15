using System;

namespace Oesia.Domain.Entities
{
    public class BookList
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public string DateWrite { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
