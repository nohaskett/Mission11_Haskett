namespace Mission11_Haskett.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
