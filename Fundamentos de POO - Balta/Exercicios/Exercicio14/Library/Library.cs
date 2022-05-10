namespace LibraryEntities
{
    public class Library
    {
        public Library()
        {
            Books = new List<Book>();
        }
        public List<Book> Books { get;  }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
    }
}