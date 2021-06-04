using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Model;
using AuthorAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AuthorAPI.Service.Books
{
    public class BookService : IBookService
    {
        public async Task<Book> AddBookAsync(Book book, int authorId)
        {
            using (DataContext context = new DataContext())
            {
                Author author = await context.Authors.FirstOrDefaultAsync(a => a.Id == authorId);
                author.Books.Add(book);
                context.Update(author);
                await context.SaveChangesAsync();
                return book;
            }
        }

        public async Task<IList<Book>> GetBooksAsync()
        {
            using (DataContext context = new DataContext())
            {
                IList<Book> books = await context.Books.ToListAsync();
                if (books != null)
                {
                    return books;
                }

                throw new Exception("Books not registered!");
            }
        }

        public async Task<string> DeleteBookAsync(int bookId)
        {
            using (DataContext context = new DataContext())
            {
                Book book = await context.Books.FirstOrDefaultAsync(b => b.ISBN == bookId);
                context.Books.Remove(book);
                await context.SaveChangesAsync();
                return "Successfully removed!";
            }
        }
    }
}