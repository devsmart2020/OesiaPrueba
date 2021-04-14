using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.DTOs
{
    public partial class CityDTO
    {

        public int IdCity { get; set; }
        public string Name { get; set; }
        public int IdCountry { get; set; }

        public CountryDTO IdCountryNavigation { get; set; }
        public IList<AuthorDTO> TbAuthors { get; set; }
    }
}
