using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_2.Domain.DTOs;
using AS_2.Domain.Entities;
using AS_2.Domain.ViewModels;
using AutoMapper;

namespace AS_2.Configuration
{
    public class AutoMapperDTO : Profile
    {
        public AutoMapperDTO()
        {
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<BookDTO, Book>().ReverseMap();
            // CreateMap<Loan, LoanDTO>().ReverseMap();
            // CreateMap<Publisher, PublisherDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<BookLoan, BookLoanDTO>().ReverseMap();
            CreateMap<BookLoanDTO, BookLoan>().ReverseMap();
            CreateMap<BookLoanDTO, BookLoanViewModel>().ReverseMap();
        }
    }
    public class AutoMapperViewModel : Profile
    {
        public AutoMapperViewModel()
        {
            CreateMap<AuthorViewModel, Author>();
            CreateMap<Author, AuthorViewModel>();
            CreateMap<BookViewModel, Book>();
            CreateMap<Book, BookViewModel>();
            CreateMap<BookViewModel, BookDTO>();
            // CreateMap<LoanViewModel, Loan>();
            // CreateMap<PublisherViewModel, Publisher>();
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();
            CreateMap<BookLoanViewModel, BookLoan>().ReverseMap();
            CreateMap<BookLoanViewModel, BookLoanDTO>().ReverseMap();
            CreateMap<BookLoan, BookLoanViewModel>().ReverseMap();
        }
    }
}