using BookStoreAPI.Handlers;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BookStoreAPI.Extension
{
    public static class EndpointRouteBuilderExtension
    {
        public static void RegisterBooksEndpoints(this IEndpointRouteBuilder endpointRouteBuilder)
        {
            var bookEndpoints = endpointRouteBuilder.MapGroup("/books");
            bookEndpoints.MapGet("", BookHandlers.GetBooks);
            bookEndpoints.MapPut("", BookHandlers.UpdateBook);
            var bookEndpointswithId = bookEndpoints.MapGroup("/{id}");
            bookEndpointswithId.MapDelete("", BookHandlers.DeleteBook);
            var saveBookEndpoint = bookEndpoints.MapGroup("/saveBook");
            saveBookEndpoint.MapPost("", BookHandlers.SaveBook);
        }
    }
}
