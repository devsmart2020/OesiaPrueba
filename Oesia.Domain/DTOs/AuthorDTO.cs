using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.DTOs
{
    public partial class AuthorDTO
    {

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int Gender { get; set; }
        public int? NumberBooks { get; set; }
        public int City { get; set; }

        public CityDTO CityNavigation { get; set; }
        public IList<BookDTO> TbBooks { get; set; }
    }
}
