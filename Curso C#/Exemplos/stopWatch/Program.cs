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
            Console.WriteLine("Para contar em segundos tecle        S");
            Console.WriteLine("Exemplo 10S para contar 10 segundos");
            Console.WriteLine("Para contar em Minutos tecle         M");
            Console.WriteLine("Exemplo 10M para contar 10 minutos");
            Console.WriteLine("Para sair tecle                      0");
            Console.WriteLine("Quanto tempo deseja contar?");
            try{
                data = Console.ReadLine().ToLower();
            }catch{
                Console.WriteLine("O valor digitado é ivalido");
                Console.ReadKey();
                Menu();
            }
            if( data!="0"){
                char type = char.Parse(data.Substring(data.Length-1,1));
                if (type == 's'){
                    try{
                        PreStart(int.Parse(data.Substring(0,data.Length-1)));        
                    }catch{
                        Console.WriteLine("O valor digitado é ivalido");
                        Console.ReadKey();
                        Menu();
                    }
                }else if(type == 'm'){
                     try{
                        PreStart(int.Parse(data.Substring(0,data.Length-1))*60);        
                    }catch{
                        Console.WriteLine("O valor digitado é ivalido");
                        Console.ReadKey();
                        Menu();
                    }
                }
            }

        }
        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0 ;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;  
                Console.WriteLine(currentTime);  
                Thread.Sleep(1000);
            }
            Console.WriteLine("StopWatch Finalisado");
            Thread.Sleep(2500);
            Menu();
        }

    }
}