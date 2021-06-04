using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AuthorBlazor.Model;
using Microsoft.Extensions.Logging;

namespace AuthorBlazor.Data.AuthorData
{
    public class AuthorService : IAuthorService
    {
        private HttpClient client = new HttpClient();
        private string uri = "https://localhost:5003";
        public async Task<string> AddAuthorAsync(Author author)
        {
            string serialize = JsonSerializer.Serialize(author);

            StringContent content = new StringContent(
                serialize,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync($"{uri}/authors" , content);
            return "Successful";
        }

        public async Task<IList<Author>> GetAuthorsAsync()
        {
            HttpResponseMessage response = await client.GetAsync($"{uri}/authors");
            if (response.IsSuccessStatusCode)
            {
                string asJson = await response.Content.ReadAsStringAsync();
                IList<Author> authors = JsonSerializer.Deserialize<IList<Author>>(asJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return authors;
            }

            throw new Exception(response.Content.ReadAsStringAsync().Result);
        }
    }
}