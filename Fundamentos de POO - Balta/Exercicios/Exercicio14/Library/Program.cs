using UserSolicitor;
using Library.Entities;
namespace Program
{
    public class Program{
        public static void Main(string[] args)
        {
            Menu(new Library());
        }
        public void Menu(Library lib)
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
                    //AddBook()ANCHOR criar função de adição de livros
                    break;
                case 2:
                    //ConsultBook() ANCHOR criar função de consulta
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                //ANCHOR ADICIONAR FUNÇÃO DE EXCLUIR LIVROS
            }
        }

    }
}