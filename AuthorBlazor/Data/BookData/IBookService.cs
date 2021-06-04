using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Data.BookData
{
    public interface IBookService
    {
        Task<string> AddBookAsync(Book book, int authorId);
        Task<IList<Book>> GetBooksAsync();
        Task<string> DeleteBookAsync(int bookId);
    }
}