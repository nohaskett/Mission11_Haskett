using System.ComponentModel.DataAnnotations;

namespace Mission11_Haskett.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int IBSN { get; set; }
        public string Category { get; set; }
        public int NumberOfPages { get; set; }
        public int Price { get; set; }
    }
}
