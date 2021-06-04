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

            await client.PostAsync($"{uri}/books", content);
            return "Successful";
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

            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<string> DeleteBookAsync(int bookId)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{uri}/books/{bookId}");
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}