using AutoMapper;
using BookStoreAPI.Dto;
using BookStoreAPI.Model;

namespace BookStoreAPI.Mapper
{
    public class BookMapperProfile:Profile
    {
        public BookMapperProfile()
        {
            CreateMap<BookDto, Book>();
            CreateMap<Book, BookDto>();
        }
    }
}
