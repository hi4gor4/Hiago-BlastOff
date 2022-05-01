namespace Library.Entities
{
    public class Book
    {
        public Book(int numberPages, string title, string author)
        {
            NumberPages = numberPages;
            Title = title;
            Id = Guid.NewGuid();
            Author = author;
        }
        public Book()
        {
            Title = "";
        }

        public int NumberPages { get; set; }
        public string  Title { get; set; }
        
        public string ISBN { get; set; } 

        public Guid Id { get;  }
        public string Author { get; set; }

        public void DisplayData(){
            if(Title != null){
                Console.WriteLine($"Titulo: {Title} ");
                Console.WriteLine($"Numero de paginas: {this.NumberPages}");
                Console.WriteLine($"ISBN: {this.ISBN}");
            }
        }
    }
}