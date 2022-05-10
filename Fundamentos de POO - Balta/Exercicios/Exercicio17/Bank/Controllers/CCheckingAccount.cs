using BankEntities;
using UserSolicitor;

namespace Bank.Controllers
{
    public class CCheckingAccount
    {
        //ANCHOR criar construtor, tornar client account disponivel para todos os metodos, sem ter que passalo de parametro
        //ANCHOR privar metodos chamados na classe
        public static void MenuCheckingAccount(CheckingAccount clientAccount)
        {
            Console.Clear();
            //ANCHOR fazer um visualizador de dados da conta corrente
            Console.WriteLine("Gerenciador de conta corrente");
            Console.WriteLine("1- Para fazer um deposito");
            Console.WriteLine("2- Para Fazer uma transferencia");
            Console.WriteLine("3- Para cobrar a taxa de manutenção da conta");
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
       
        public static void RequestMonthlyPayment(CheckingAccount clientAccount)
        {
            if(clientAccount.DeductsMonthlyFee()){
                Console.WriteLine($"As taxas foram cobrados com sucesso, seu novo saldo é de  {clientAccount.GetBalance()}");
            }else{
                Console.WriteLine("Não é possivel pagar as taxas, seu saldo é insuficiente.");
                Console.WriteLine("Favor faça um deposito.");
            }
            
        }
    }
}