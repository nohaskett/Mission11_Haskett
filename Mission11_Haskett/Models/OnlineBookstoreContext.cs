using Microsoft.EntityFrameworkCore;

namespace Mission11_Haskett.Models
{
    public class OnlineBookstoreContext : DbContext
    {
        public OnlineBookstoreContext(DbContextOptions<OnlineBookstoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books"); // Map Book entity to the existing "Books" table
            base.OnModelCreating(modelBuilder);
        }
    }
}
