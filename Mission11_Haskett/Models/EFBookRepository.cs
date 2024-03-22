namespace Mission11_Haskett.Models
{
    public class EFBookRepository : IBookRepository
    {
        private OnlineBookstoreContext _context;
        public EFBookRepository(OnlineBookstoreContext temp) { 
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
