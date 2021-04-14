using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbCity
    {
        public TbCity()
        {
            TbAuthors = new HashSet<TbAuthor>();
        }

        public int IdCity { get; set; }
        public string Name { get; set; }
        public int IdCountry { get; set; }

        public virtual TbCountry IdCountryNavigation { get; set; }
        public virtual ICollection<TbAuthor> TbAuthors { get; set; }
    }
}
