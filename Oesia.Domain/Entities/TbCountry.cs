using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbCountry
    {
        public TbCountry()
        {
            TbCities = new HashSet<TbCity>();
        }

        public int IdCountry { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TbCity> TbCities { get; set; }
    }
}
