using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorAPI.Model;
using AuthorAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuthorAPI.Service.Books
{
    public class BookService : IBookService
    {
        public async Task<string> AddBookAsync(Book book, int authorId)
        {
            using (DataContext context = new DataContext())
            {
                EntityEntry<Book> toAdd = await context.Books.AddAsync(book);
                if (toAdd != null)
                {
                    Author auth = await context.Authors.Include(b => b.Books)
                        .FirstOrDefaultAsync(a => a.Id == authorId);
                    auth.Books.Add(toAdd.Entity);
                    context.Update(auth);
                    await context.SaveChangesAsync();
                    return "Successful!";
                }
                throw new Exception("Cannot add the book!");
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
                throw new Exception("No books registered!");
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