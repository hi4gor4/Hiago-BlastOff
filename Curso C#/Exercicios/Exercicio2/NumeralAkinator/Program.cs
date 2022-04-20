using System;
namespace RandonNumber{
    public class Program{
        static void Main(){
            Akinator aki = new Akinator(5);
            Menu(aki);




        }
        static void Menu(Akinator aki){
            short num = HandleOptions();
            if(num !=6){
                if(aki.VerificaNumber(num)){
                    Console.WriteLine("Era exatamente nisso que eu tava pensando cara!");
                    Console.ReadKey();
                    Main();
                }else{
                    Console.WriteLine("Xiiiiii, Não foi dessa vez cara! Tente novamente");
                    Console.ReadKey();
                    Menu(aki);
                }
            }

        }
        static short HandleOptions(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Você consegue adivinhar o numero que eu tô pensando?");
            Console.WriteLine("Bom vou te dar uma dica tá? É um numero entre 0 e 5");
            Console.WriteLine("Caso não seja capaz escolha 6");
            short option = 0;
            try{
                option = short.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Por favor insira um numero valido");
                Console.ReadKey();
                return HandleOptions();
            }
            if(option <= 6 && option>=0){
                return option;
            }else {
                Console.WriteLine("Poxa cara você nem sequer tá tentando, vamo la tenta me dar um numero entre 0 e 5...");
                Console.ReadKey();
                return HandleOptions();
            }
        }
    }
}