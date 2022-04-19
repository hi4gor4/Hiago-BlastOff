using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Escolha qual operação deseja realizar");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtracao");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisao");
            Console.WriteLine("5-Para sair");
            short res = 0;
            try{
                res = short.Parse(Console.ReadLine());
            }catch{
                Menu();
            }
            switch (res){
                case 1:     
                    Soma();
                    break;
                case 2:   
                    Subtracao(); 
                    break;
                case 3:
                    Multiplicacao();
                    break;
                case 4:
                    Divisao();
                    break;
                case 5:
                    System.Environment.Exit(0);  
                    break;  
                default:
                    Menu();
                    break;
            }
        }
        static void Soma(){
            float valor1 = 0, valor2 = 0;
            Console.Clear();
            Console.WriteLine("Insira um valor:\n");
            
            try{
                 valor1 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0");
            }

            Console.WriteLine("Insira mais um valor:\n");
            try{
                 valor2 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0)");
            }
            Console.Clear();
            Console.WriteLine($"O resultado da soma é de : {valor1 + valor2}");
            Console.ReadKey();
            Menu();

        }

        static void Subtracao(){
            float valor1 = 0, valor2 = 0;
            Console.Clear();
            Console.WriteLine("Insira um valor:\n");
            
            try{
                 valor1 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0");
            }

            Console.WriteLine("Insira mais um valor:\n");
            try{
                 valor2 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0)");
            }
            Console.Clear();
            Console.WriteLine($"O resultado da subtracao é de : {valor1 - valor2}");
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao(){
            float valor1 = 0, valor2 = 0;
            Console.Clear();
            Console.WriteLine("Insira um valor:\n");
            
            try{
                 valor1 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0");
            }

            Console.WriteLine("Insira mais um valor:\n");
            try{
                 valor2 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0)");
            }
            Console.Clear();
            Console.WriteLine($"O resultado da multiplicacao é de : {valor1 * valor2}");
            Console.ReadKey();
            Menu();

        }
        static void Divisao(){
            float valor1 = 0, valor2 = 0;
            Console.Clear();
            Console.WriteLine("Insira um valor:\n");
            
            try{
                 valor1 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0");
            }

            Console.WriteLine("Insira mais um valor:\n");
            try{
                 valor2 = float.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor iserido é invaldo e foi considerado 0)");
            }
            Console.Clear();
            Console.WriteLine($"O resultado da divisão é de : {valor1 / valor2}");
            Console.ReadKey();
            Menu();
        }
    }
}