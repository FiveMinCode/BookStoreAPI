using BookStoreAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Respository
{
    public class BookStoreDb: DbContext
    {
        public BookStoreDb(DbContextOptions<BookStoreDb> options): base(options)
        {
        }

        public DbSet<Book> Books => Set<Book>();
    }
}
