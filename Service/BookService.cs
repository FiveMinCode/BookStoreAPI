using BookStoreAPI.Model;
using BookStoreAPI.Respository;

namespace BookStoreAPI.Service
{
    public class BookService : IBookService
    {
        private readonly BookStoreDb _bookStoreDb;
        public BookService(BookStoreDb bookStoreDb)
        {
            _bookStoreDb = bookStoreDb;
        }
        public bool DeleteBook(int id)
        {
            var booktoBedeleted = _bookStoreDb.Books.FirstOrDefault(t=> t.Id == id);
            if (booktoBedeleted != null)
            {
                _bookStoreDb.Remove(booktoBedeleted);
                return true;
            }
            return false;
        }

        public Book GetBook(int id)
        {
            return _bookStoreDb.Books.FirstOrDefault(t => t.Id == id)!;
        }

        public List<Book> GetBooks()
        {
            return _bookStoreDb.Books.ToList();
        }

        public Book SaveBook(Book book)
        {
            _bookStoreDb.Add(book);
            _bookStoreDb.SaveChanges();
            return book;
        }

        public Book UpdateBook(Book book)
        {
            _bookStoreDb.Update(book);
            _bookStoreDb.SaveChanges();
            return book;
        }
    }
}
