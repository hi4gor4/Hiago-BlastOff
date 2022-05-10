using BankEntities;
using UserSolicitor;

namespace Bank.Controllers
{
    public class CSavingsAccount
    {
        
  

        public static void MenuSavingAccount(SavingsAccount clientAccount){
            //ANCHOR colocar um visualizador de dados
            Console.WriteLine("Gerenciador de conta poupança");
            Console.WriteLine("1- Para fazer um deposito");
            Console.WriteLine("2- Para Fazer uma transferencia");
            Console.WriteLine("3- Para receber a taxa de rendimentos da conta");
            Console.WriteLine("4- Para encerar as atividades");
            var option = Solicitor.GetByteInterval(1,4);
            switch(option){
                case 1:
                    CAccount.RequestDepositValue(clientAccount);
                    break;
                case 2:
                    CAccount.RequestWithdrawal(clientAccount);
                    break;
                case 3:
                    RequestMonthlyPayment(clientAccount);
                    break;
                case 4:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
        }
        public static void RequestMonthlyPayment(SavingsAccount clientAccount)
        {
            Console.WriteLine($"A sua economia foi de {clientAccount.CalculateIncome(1)} ");
            clientAccount.MakeDeposit(clientAccount.CalculateIncome(1));

        }
       
    }
}