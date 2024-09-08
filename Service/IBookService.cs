using BookStoreAPI.Model;

namespace BookStoreAPI.Service
{
    public interface IBookService
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        Book SaveBook(Book book);
        Book UpdateBook(Book book);
        bool DeleteBook(int id);
    }
}
