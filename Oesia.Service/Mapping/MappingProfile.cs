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
        }
    }
}
