using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.DTOs
{
    public partial class CountryDTO
    {
        public int IdCountry { get; set; }
        public string Name { get; set; }

        public IList<CityDTO> TbCities { get; set; }
    }
}
