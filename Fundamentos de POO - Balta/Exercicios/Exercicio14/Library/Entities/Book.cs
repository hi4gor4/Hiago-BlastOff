namespace LibraryEntities
{
    public class Book
    {
        public Book(uint numberPages, string title, string author,string  isbn)
        {
            NumberPages = numberPages;
            ISBN = isbn;
            Title = title;
            Id = Guid.NewGuid();
            Author = author;
        }
        public Book()
        {
            Title = "";
            ISBN = "";
        }

        public uint NumberPages { get; set; }
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