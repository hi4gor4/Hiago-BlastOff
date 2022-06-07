namespace DataAccess.Model
{
    public class Category
    {
        public Category(Guid id, string title)
        {
            Id = id;
            Title = title;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}