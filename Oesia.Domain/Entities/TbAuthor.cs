using System.Collections.Generic;

#nullable disable

namespace Oesia.Domain.Entities
{
    public partial class TbAuthor
    {
        public TbAuthor()
        {
            TbBooks = new HashSet<TbBook>();
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int IdGender { get; set; }
        public int? NumberBooks { get; set; }
        public int IdCity { get; set; }
        public int? IdState { get; set; }
        public int? IdCountry { get; set; }

        public virtual TbCity IdCityNavigation { get; set; }
        public virtual TbGender IdGenderNavigation { get; set; }
        public virtual ICollection<TbBook> TbBooks { get; set; }
    }
}
