using BankEntities;
using UserSolicitor;

namespace Bank.Controllers
{
    public class CAccount
    {
         public static void RequestDepositValue(Account clientAccount)
        {
            Console.WriteLine("Insira o valor a ser depositado");
            double depositValue = Solicitor.GetValidpositiveDouble();
            clientAccount.MakeDeposit(depositValue);
            Console.WriteLine("Deposito Realizado com sucesso"); 
        }

        public static void RequestWithdrawal(Account clientAccount)
        {
            Console.WriteLine("Insira o valor a ser sacado");
            double widthdrawal = Solicitor.GetValidpositiveDouble();
            if(clientAccount.MakeWithdrawal(widthdrawal)){
                Console.WriteLine("Saque realizado com sucesso");
            }
        }
    }
}