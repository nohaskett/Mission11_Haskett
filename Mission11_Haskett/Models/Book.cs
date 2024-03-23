using System.ComponentModel.DataAnnotations;

namespace Mission11_Haskett.Models
{
    public class Book // Set up all the attributes for 1 book record
    {
        [Key]
        public int BookID { get; set; } // Primary key, make sure this matches the database exactly
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public string Classification { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public float Price { get; set; }
    }
}
