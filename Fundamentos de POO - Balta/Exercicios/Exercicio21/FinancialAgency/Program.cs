using UserSolicitor;
using System;
using FinancialAgency;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("1- Para inserir um contrato de pessoa fisica");
            Console.WriteLine("2- Para inserir um contrato de pessoa juridica");
            Console.WriteLine("3- Para sair");
            byte option = Solicitor.GetByteInterval(1,3);
            Contract contr;
            switch(option)
            {
                case 1:
                    contr = CadastrarContrato();
                    ContratoMenu(contr);
                    break;
                case 2:
                    contr = CadastrarContratoPJ();
                    ContratoMenu(contr);
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }
        }
        static IndividualContract CadastrarContrato()
        {
            Console.WriteLine("Insira o numero do contrato");
            int number = Solicitor.GetValidInt();
            Console.WriteLine("Insira o nome do contratante");
            string contractor = Solicitor.GetValidName();
            Console.WriteLine("Insira o valor do contrato");
            float value = (float)Solicitor.GetValidpositiveDouble();
            Console.WriteLine("Insira o prazo em messes");
            int term = Solicitor.GetValidpositiveInt();
            Console.WriteLine("Favor insira seu cpf");
            string cpf = Solicitor.GetValidCPF();
            Console.WriteLine("Insira sua idade");
            int age = Solicitor.GetValidpositiveInt();
            return new IndividualContract(number,contractor,value,term,cpf,age);
        }

        static LegalEntityContract CadastrarContratoPJ()
        {
            Console.WriteLine("Insira o numero do contrato");
            int number = Solicitor.GetValidInt();
            Console.WriteLine("Insira o nome do contratante");
            string contractor = Solicitor.GetValidName();
            Console.WriteLine("Insira o valor do contrato");
            float value = (float)Solicitor.GetValidpositiveDouble();
            Console.WriteLine("Insira o prazo em messes");
            int term = Solicitor.GetValidpositiveInt();
            Console.WriteLine("Favor insira seu cnpj");
            string cpf = Solicitor.GetValidString();
            Console.WriteLine("Insira seu regitro");
            string stateRegistration = Solicitor.GetValidString();
            return new LegalEntityContract(number,contractor,value,term,cpf, stateRegistration);
        }
        static void ContratoMenu(Contract contract){
            Console.WriteLine("1- Para calcular prestação");
            Console.WriteLine("2- Para exibir info do contrato");
            Console.WriteLine("3- Para sair do sistema");
            byte option = Solicitor.GetByteInterval(1,3);
            switch(option)
            {
                case 1:
                    Console.WriteLine(contract.CalculateInstallment());
                    break;
                case 2:
                    contract.ShowInfo();
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }
        }

    }
}