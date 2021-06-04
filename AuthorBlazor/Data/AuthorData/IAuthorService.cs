using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Data.AuthorData
{
    public interface IAuthorService
    {
        Task<string> AddAuthorAsync(Author author);
        Task<IList<Author>> GetAuthorsAsync();
    }
}