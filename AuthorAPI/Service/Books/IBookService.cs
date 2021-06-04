
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Model;

namespace AuthorAPI.Service.Books
{
    public interface IBookService
    {
        Task<Book> AddBookAsync(Book book, int authorId);
        Task<IList<Book>> GetBooksAsync();
        Task<string> DeleteBookAsync(int bookId);
    }
}