using AutoMapper;
using Entities.DTO;
using Entities.Models;

namespace BookStoreAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDTO>();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<CreateBookDTO, Book>();
        }
    }
}
