using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AuthorBlazor.Model
{
    public class Author
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        
        [Required, MaxLength(15)]
        [JsonPropertyName("firstname")]
        public string FirstName { get; set; }
        
        [Required, MaxLength(15)]
        [JsonPropertyName("lastname")]
        public string LastName { get; set; }
        
        [JsonPropertyName("books")]
        public IList<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
        
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}