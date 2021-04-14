using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbAuthor
    {
        public TbAuthor()
        {
            TbBooks = new HashSet<TbBook>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public int? NumberBooks { get; set; }
        public int City { get; set; }

        public virtual TbCity CityNavigation { get; set; }
        public virtual ICollection<TbBook> TbBooks { get; set; }
    }
}
