using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbGender
    {
        public TbGender()
        {
            TbAuthors = new HashSet<TbAuthor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TbAuthor> TbAuthors { get; set; }
    }
}
