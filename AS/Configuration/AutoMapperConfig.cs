using AS.Domain.DTOs;
using AS.Domain.Entities;
using AS.Domain.ViewModels;
using AutoMapper;

namespace AS.Configuration
{
    public class AutoMapperDTO : Profile
    {
        public AutoMapperDTO()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<Loan, LoanDTO>().ReverseMap();
            CreateMap<Publisher, PublisherDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
    public class AutoMapperViewModel : Profile
    {
        public AutoMapperViewModel()
        {
            CreateMap<AuthorViewModel, Author>();
            CreateMap<BookViewModel, Book>();
            CreateMap<LoanViewModel, Loan>();
            CreateMap<PublisherViewModel, Publisher>();
            CreateMap<UserViewModel, User>();
        }
    }
}
