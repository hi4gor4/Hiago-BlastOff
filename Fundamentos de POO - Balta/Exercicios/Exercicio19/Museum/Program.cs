using UserSolicitor;
namespace MyApp 
{
    public class Program{
        static void Main(string[] args)
        {
            
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Sistema de visitação");
            Console.WriteLine("1- Para cadastrar uma visita comun");
            Console.WriteLine("2- Para cadastrar uma vista simples");
            Console.WriteLine("3- Para sair");
            int option = Solicitor.GetValidInt();
            switch(option)
            {
                case 1:
                    break;
                case 2: 
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Favor insira uma opção valida");
                    break;
            }
        }
        static void CommonVisit()
        {
            Console.Clear();
            Console.WriteLine("Favor insira o seu nome");
        }
    }
}