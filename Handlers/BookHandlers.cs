using AutoMapper;
using BookStoreAPI.Dto;
using BookStoreAPI.Model;
using BookStoreAPI.Service;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Handlers
{
    public static class BookHandlers
    {
        public static async Task<Ok<BookDto>> SaveBook([FromBody] BookDto book, 
            IBookService bookService, IMapper mapper)
        {
            return TypedResults.Ok(mapper.Map<BookDto>(bookService.SaveBook(mapper.Map<Book>(book))));
        }

        public static async Task<Ok<List<BookDto>>> GetBooks(IBookService bookService, IMapper mapper)
        {
            return TypedResults.Ok(mapper.Map<List<BookDto>>(bookService.GetBooks()));
        }

        public static async Task<Ok<BookDto>> UpdateBook([FromBody] Book book,
            IBookService bookService, IMapper mapper)
        {
            return TypedResults.Ok(mapper.Map<BookDto>(bookService.UpdateBook(book)));
        }

        public static async Task<Ok<bool>> DeleteBook(int id,
            IBookService bookService, IMapper mapper)
        {
            return TypedResults.Ok(bookService.DeleteBook(id));
        }
    }
}
