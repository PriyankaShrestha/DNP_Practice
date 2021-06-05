using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AuthorBlazor.Model;

namespace AuthorBlazor.Data.BookData
{
    public class BookService : IBookService
    {
        private HttpClient client = new HttpClient();
        private string uri = "https://localhost:5003";

        public async Task<string> AddBookAsync(Book book, int authorId)
        {
            string serialize = JsonSerializer.Serialize(book);

            StringContent content = new StringContent(
                serialize,
                Encoding.UTF8,
                "application/json"
            );
            
            HttpResponseMessage message = await client.PostAsync($"{uri}/books/{authorId}", content);
            string response = await message.Content.ReadAsStringAsync(); 
            return response;
        }

        public async Task<IList<Book>> GetBooksAsync()
        {
            HttpResponseMessage response = await client.GetAsync($"{uri}/books");
            if (response.IsSuccessStatusCode)
            {
                string asJson = await response.Content.ReadAsStringAsync();
                IList<Book> books = JsonSerializer.Deserialize<IList<Book>>(asJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return books;
            }

            throw new Exception(await response.Content.ReadAsStringAsync());
        }

        public async Task<string> DeleteBookAsync(int bookId)
        {
            Console.WriteLine("Book to remove" + bookId);
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/books/{bookId}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}