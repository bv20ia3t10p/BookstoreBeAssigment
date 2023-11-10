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
            CreateMap<Author, AuthorDTO>();
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<CreateAuthorDTO, Author>();
            CreateMap<User, UserDTO>();
            CreateMap<User,UserDTO>().ReverseMap();
            CreateMap<CreateUserDTO, User>();
            CreateMap<Role, RoleDTO>();
            CreateMap<Role,RoleDTO>().ReverseMap();
            CreateMap<CreateRoleDTO, Role>();
        }
    }
}
