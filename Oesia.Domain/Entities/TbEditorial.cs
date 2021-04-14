using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbEditorial
    {
        public TbEditorial()
        {
            TbBooks = new HashSet<TbBook>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<TbBook> TbBooks { get; set; }
    }
}
