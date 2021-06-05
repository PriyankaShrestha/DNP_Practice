using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.Model;

namespace AuthorAPI.Service
{
    public interface IAuthorService
    {
        Task<string> AddAuthorAsync(Author author);
        Task<IList<Author>> GetAuthorsAsync();
    }
}