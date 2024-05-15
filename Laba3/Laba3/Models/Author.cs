using System.ComponentModel.DataAnnotations.Schema;

namespace Laba3.Models
{
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
