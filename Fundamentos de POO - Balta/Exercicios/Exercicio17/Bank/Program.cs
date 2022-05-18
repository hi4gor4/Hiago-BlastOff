using Bank.Controllers;
using BankEntities;
using UserSolicitor;
namespace BankAplicattion
{
    public class program
    {
        static void Main(string[] args)
        {
            Menu();
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
                    RegisterCurrentAccount();
                    break;
                case 2:
                    RegisterSavingsAccount();
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            } 
        }
        static void RegisterCurrentAccount()
        {
            Console.Clear();
            Console.WriteLine("Para cadastrar sua conta corrente, eu vou precisar dos seus dados, vamos lá?");
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            Console.WriteLine("Favor imsira o numero da conta");
            int number = Solicitor.GetValidpositiveInt();
            Console.WriteLine("Favor insira sua agencia bancaria");
            int bankBranch = Solicitor.GetValidpositiveInt();
            Console.WriteLine("Insira seu saldo");
            double balance = Solicitor.GetValidDouble();
            Console.WriteLine("Favor insira a taxa de manutenção da sua conta");
            double monthlyPayment = Solicitor.GetValidpositiveDouble();
            CCheckingAccount.MenuCheckingAccount(new CheckingAccount(number.ToString(), bankBranch, balance, monthlyPayment)); 


        }

        static void RegisterSavingsAccount()
        {
            Console.Clear();
            Console.WriteLine("Para cadastrar sua conta corrente, eu vou precisar dos seus dados, vamos lá?");
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            Console.WriteLine("Favor imsira o numero da conta");
            int number = Solicitor.GetValidpositiveInt();
            Console.WriteLine("Favor insira sua agencia bancaria");
            int bankBranch = Solicitor.GetValidpositiveInt();
            Console.WriteLine("Insira seu saldo");
            double balance = Solicitor.GetValidDouble();
            Console.WriteLine("Favor insira a taxa de rendimentos da sua conta");
            double inconome = Solicitor.GetValidpositiveDouble();
            CSavingsAccount.MenuSavingAccount(new SavingsAccount(number.ToString(), bankBranch, balance,inconome)); 


        }
    }
}