using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace AuthorAPI.Model
{
    public class Book
    {
        [Key]
        [JsonPropertyName("isbn")]
        public int ISBN { get; set; }
        
        [Required, MaxLength(40)]
        [JsonPropertyName("title")]
        public string Title { get; set; }
        
        [JsonPropertyName("pubyear")]
        public int PublicationYear { get; set; }
        
        [JsonPropertyName("pages")]
        public int NumOfPages { get; set; }
        
        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        public override string ToString()
        {
            return ISBN + " " + "Title";
        }
    }
}