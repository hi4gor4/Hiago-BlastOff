namespace DataAccess.Model
{
    public class Category
    {
        public Category(Guid id, string title)
        {
            Id = id;
            Title = title;
        }
        public Category()
        {
            
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Summary { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public bool Featured { get; set; }
    }
}