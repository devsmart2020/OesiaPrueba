using System;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime WriteDate { get; set; }
        public DateTime? LaunchDate { get; set; }
        public decimal Price { get; set; }
        public int IdAuthor { get; set; }
        public int IdEditorial { get; set; }
        public string Remarks { get; set; }

        public virtual TbAuthor IdAuthorNavigation { get; set; }
        public virtual TbEditorial IdEditorialNavigation { get; set; }
    }
}
