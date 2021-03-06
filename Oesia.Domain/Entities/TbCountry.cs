using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbCountry
    {
        public TbCountry()
        {
            TbStates = new HashSet<TbState>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TbState> TbStates { get; set; }
    }
}
