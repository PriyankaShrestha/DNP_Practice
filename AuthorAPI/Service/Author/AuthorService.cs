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
        public async Task<Author> AddAuthorAsync(Author author)
        {
            using (DataContext context = new DataContext())
            {
                Console.WriteLine(author.ToString());
                EntityEntry<Author> toAdd = await context.Authors.AddAsync(author);
                if (toAdd != null)
                {
                    Console.WriteLine(toAdd.Entity + "///////////********************");
                    await context.SaveChangesAsync();
                    return toAdd.Entity;
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