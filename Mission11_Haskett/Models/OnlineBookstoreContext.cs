using Microsoft.EntityFrameworkCore;

namespace Mission11_Haskett.Models
{
    public class OnlineBookstoreContext : DbContext
    {
        public OnlineBookstoreContext (DbContextOptions<OnlineBookstoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
