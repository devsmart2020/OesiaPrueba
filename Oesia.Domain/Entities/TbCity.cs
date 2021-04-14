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

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdState { get; set; }

        public virtual TbState IdStateNavigation { get; set; }
        public virtual ICollection<TbAuthor> TbAuthors { get; set; }
    }
}
