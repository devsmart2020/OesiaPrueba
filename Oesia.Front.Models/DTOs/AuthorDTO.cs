namespace Oesia.Front.Models.DTOs
{
    public class AuthorDTO
    {
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
    }
}
