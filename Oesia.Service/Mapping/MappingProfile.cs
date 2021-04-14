using AutoMapper;
using Oesia.Domain.Entities;
using Oesia.Infrastructure.DTOs;

namespace Oesia.Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TbAuthor, AuthorDTO>();
            CreateMap<AuthorDTO, TbAuthor>();
            CreateMap<AuthorList, AuthorListDTO>();
            CreateMap<TbBook, BookDTO>();
            CreateMap<BookDTO, TbBook>();
            CreateMap<BookList, BookListDTO>();
            CreateMap<TbCity, CityDTO>();
            CreateMap<CityDTO, TbCity>();
            CreateMap<TbCountry, CountryDTO>();
            CreateMap<CountryDTO, TbCountry>();
        }
    }
}
