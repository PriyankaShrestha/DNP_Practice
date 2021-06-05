using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Model;
using AuthorAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuthorAPI.Service
{
    public class AuthorService : IAuthorService
    {
        public async Task<string> AddAuthorAsync(Author author)
        {
            using (DataContext context = new DataContext())
            {
                Console.WriteLine(author.ToString());
                EntityEntry<Author> toAdd = await context.Authors.AddAsync(author);
                if (toAdd != null)
                {
                    await context.SaveChangesAsync();
                    return "Successful!";
                }
                throw new Exception("Failed to add the author!");
            }
        }

        public async Task<IList<Author>> GetAuthorsAsync()
        {
            using (DataContext context = new DataContext())
            {
                IList<Author> authors = await context.Authors.Include(b => b.Books).ToListAsync();
                if (authors != null)
                {
                    return authors;
                }
                throw new Exception("No authors registered!");
            }
        }
    }
}