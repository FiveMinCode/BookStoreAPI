using AutoMapper;
using BookStoreAPI.Dto;
using BookStoreAPI.Extension;
using BookStoreAPI.Model;
using BookStoreAPI.Respository;
using BookStoreAPI.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IBookService, BookService>();
builder.Services.AddDbContext<BookStoreDb>(opt => opt.UseInMemoryDatabase("BookStore"));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.RegisterBooksEndpoints();

//app.MapPost("/saveBook", async (BookDto book, IBookService bookService, IMapper mapper) =>
//    TypedResults.Ok(mapper.Map<BookDto>(bookService.SaveBook(mapper.Map<Book>(book)))));

//app.MapGet("/books", (IBookService bookService, IMapper mapper) =>
//    TypedResults.Ok(mapper.Map<List<BookDto>>(bookService.GetBooks())));

//app.MapPut("/books", (Book book, IBookService bookService, IMapper mapper) =>
//    TypedResults.Ok(mapper.Map<BookDto>(bookService.UpdateBook(book))));

//app.MapDelete("/books/{id}", async (int id, IBookService bookService) =>
//    TypedResults.Ok(bookService.DeleteBook(id)));

app.Run();
