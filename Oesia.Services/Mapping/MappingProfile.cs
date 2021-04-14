using AutoMapper;
using Oesia.Domain.DTOs;
using Oesia.Domain.Entities;

namespace Oesia.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TbAuthor, AuthorDTO>();
            CreateMap<AuthorDTO, TbAuthor>();
            CreateMap<TbBook, BookDTO>();
            CreateMap<BookDTO, TbBook>();
            CreateMap<TbCity, CityDTO>();
            CreateMap<CityDTO, TbCity>();
            CreateMap<TbCountry, CountryDTO>();
            CreateMap<CountryDTO, TbCountry>();
        }
    }
}
