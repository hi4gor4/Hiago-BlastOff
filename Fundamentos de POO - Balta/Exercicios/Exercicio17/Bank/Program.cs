using UserSolicitor;
namespace BankAplicattion
{
    public class program
    {
        static void Main(string[] args)
        {

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo ao BEMBANCO");
            Console.WriteLine("É  um prazer te receber como cliente");
            Console.WriteLine("Vamos lá, primeiro quero saber se você quer ingressar como cliente de conta poupança ou de conta corrente ");
            Console.WriteLine("1- Correntista");
            Console.WriteLine("2- Poupança");
            Console.WriteLine("3- Não quero virar cliente");
            byte option = Solicitor.GetByteInterval(1,3);
            switch(option)
            {
                case 1:
                    //ANCHOR adicionar cadastro de conta corrente
                    break;
                case 2:
                    // ANCHOR adicionar cadastro de conta poupança
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            } 
        }
    }
}