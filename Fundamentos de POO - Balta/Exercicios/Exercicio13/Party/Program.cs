using UserSolicitor;
namespace Party
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();    
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Cadastrar um novo ingresso");
            Console.WriteLine("2 - Cadastrar um novo ingresso Vip");
            Console.WriteLine("3 - Para Sair");
            short option = Solicitor.GetShortInterval(1,3);
            switch(option){
                case 1:
                    break;
                case 2: 
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }
        }
        
    }
}