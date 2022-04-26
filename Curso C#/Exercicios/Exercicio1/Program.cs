using System;
using System.Threading;
namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            string data = "";
            Console.Clear();
            Console.WriteLine("Insira um valor entre 0 e 9999");
            Console.WriteLine("Insira * para sair");
   
            try{
                data = Console.ReadLine();
            }catch{
                Console.WriteLine("O valor digitado é ivalido");
                Console.ReadKey();
                Menu();
            }
            if( data!="*"){
                try{
                if(int.Parse(data) >= 0 && int.Parse(data) <= 9999){
                    SeparaNumero(data);
                }else{
                    Console.WriteLine("O valor recebido não está no escopo previsto, tente novamente...");
                    Console.ReadKey();
                }       
                }catch{
                    Console.WriteLine("O valor digitado não é um inteiro valido");
                    Console.ReadKey();
                    Menu();
                }
              
            }else{
                System.Environment.Exit(0);
            }
            static void SeparaNumero(string num){
                switch(num.Length)
                {
                    case 1:
                        Unidade(num);
                        break;
                    case 2: 
                        Dezena(num);
                        break;
                    case 3:
                        Centena(num);
                        break;
                    case 4:
                        Milhar(num);
                        break;            

                }
                Console.WriteLine("Presione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                Menu();
            }
            static void Unidade(string num){
                Console.WriteLine($"Unidade: {num[0]}");
            }

            static void Dezena(string num){
                Unidade(num);
                Console.WriteLine($"Dezena: {num[1]}");
            }
            
            static void Centena(string num){
                Dezena(num);
                Console.WriteLine($"Centena: {num[2]}");
            }

            static void Milhar(string num){
                Centena(num);
                Console.WriteLine($"Unidade de milhar: {num[3]}");
            }

        }
    }
}

