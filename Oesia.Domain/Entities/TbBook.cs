using System;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbBook
    {
        public int IdBook { get; set; }
        public string Name { get; set; }
        public DateTime WriteDate { get; set; }
        public decimal Price { get; set; }
        public int AuthorId { get; set; }

        public virtual TbAuthor Author { get; set; }
    }
}
