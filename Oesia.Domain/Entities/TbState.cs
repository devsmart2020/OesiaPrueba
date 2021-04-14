using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbState
    {
        public TbState()
        {
            TbCities = new HashSet<TbCity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCountry { get; set; }

        public virtual TbCountry IdCountryNavigation { get; set; }
        public virtual ICollection<TbCity> TbCities { get; set; }
    }
}
