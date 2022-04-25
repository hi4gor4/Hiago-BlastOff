using System;

namespace ValidaTelefone // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            while(true){
                Console.Clear();
                Console.WriteLine("valida e corrige numero de telefone");
                Console.WriteLine("Para validar um numero tecle            1");
                Console.WriteLine("Para sair tecle                         2");
                short opt = 0;
                try{
                    opt = short.Parse(Console.ReadLine());
                }catch{
                    Console.WriteLine("Favor insira um valor inteiro, pressione qualquer tecla para prosseguir...");
                    Console.ReadKey();
                    Menu();
                }
                if(opt == 1){
                    verificaTelefone();
                }else if( opt == 2){
                    System.Environment.Exit(0);
                }else{
                    Console.WriteLine("Opção invalida, pressione qualquer tecla para prosseguir...");
                    Console.ReadKey();
                    Menu();
                }
            }
        }
        static void verificaTelefone(){
            Console.Clear();
            Console.WriteLine("Favor insira o numero do telefone:" );
            string num = Console.ReadLine();
            if(num == null){
                verificaTelefone();
            }else{
                ValidaTelefone v = new ValidaTelefone();
                Console.WriteLine(String.Join( "\n", v.Valid(num)));
                Console.WriteLine("Pressione qualquer tecla para prosseguir");
                Console.ReadKey();

            }

        }
    }
}