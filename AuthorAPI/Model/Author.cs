using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AuthorAPI.Model
{
    public class Author
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }
        
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }
        
        [JsonPropertyName("books")]
        public IList<Book> Books { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}