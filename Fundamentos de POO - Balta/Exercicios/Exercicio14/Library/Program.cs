using UserSolicitor;
using LibraryEntities;
namespace Program
{
    public class Program{
        public static void Main(string[] args)
        {
            Menu(new Library());
        }
        public static void Menu(Library lib)
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo a biblioteca de Alexandria");
            Console.WriteLine("1-Para cadastrar um novo livro");
            Console.WriteLine("2-Para consultar um livro cadastrado");
            Console.WriteLine("3-Para sair do sistema");
            byte option = Solicitor.GetByteInterval(1,3);
            switch(option)
            {
                case 1:
                    lib.AddBook(RequestBook());//ANCHOR criar função de adição de livros
                    break;
                case 2:
                    ConsultBook(lib); //ANCHOR criar função de consulta
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                //ANCHOR ADICIONAR FUNÇÃO DE EXCLUIR LIVROS
            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            Menu(lib);

        }
        static Book RequestBook()
        {
            Console.WriteLine("Prossiga para cadastrar os dados");
            Console.WriteLine("Primeiro insira o numero de paginas");
            uint numberPages = Solicitor.GetValidUint();//ANCHOR verificar numero de paginas 0
            Console.WriteLine("Agora insira o titulo do livro");
            string title = Solicitor.GetValidString();
            Console.WriteLine("Favor insira o nome do autor");
            string author = Solicitor.GetValidName();
            Console.WriteLine("Insira seu numero ISBN");
            Console.WriteLine("Siga o padrão: 000-00-000-0000-0");
            string isbn = Solicitor.GetValidString();//ANCHOR criar solicitor de isbn
            return new Book(numberPages, title, author, isbn);
        }

        static void ConsultBook(Library lib)
        {
            Console.Clear();
            Console.WriteLine("Escolha a informação usada para consultar o livro");
            Console.WriteLine("1-ISBN");
            Console.WriteLine("2-Author");
            Console.WriteLine("3-Title");
            byte option = Solicitor.GetByteInterval(1,3);
            switch(option)
            {
                case 1:
                    ConsultByTitle(lib);
                    break;
                case 2:
                    //ANCHOR criar fução para PEGAR pelo author
                    break;
                case 3:
                //ANCHOR criar função parar pegar pelo isbn
                    break;
                
            }
            
        }
        static void ConsultByTitle(Library lib)
        {
            Console.Clear();
            Console.WriteLine("Insira o titulo do livro");
            string title = Solicitor.GetValidString();
            Console.Clear();
            bool occurrence  = false;
            foreach(Book book in lib.Books)
            {
                if(book.Title == title)
                {
                    Console.WriteLine($"{book.Title} do autor {book.Author} codigo ISBN{book.ISBN}");
                    occurrence = true;
                }
            }
            if(!occurrence)
            {
                Console.WriteLine("Não encontramos nenhuma correspondencia para esse titulo");
            }


        }
    }
}