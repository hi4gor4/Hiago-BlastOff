using System;
using System.IO;
namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            short option = 0;
            Console.Clear();
            Console.WriteLine("Para abrir um arquivo tecle      1");
            Console.WriteLine("Para criar um arquivo tecle      2");
            Console.WriteLine("Para sair tecle                  0");
            try{
                option = short.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Insira um numero valido...");
                Console.ReadKey();
                Menu();
            }
            switch(option){
                case 1:
                    AbrirArquivo();
                    break;
                case 2:
                    Salvar(EditarArquivo());

                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;            
            }
        }
        static string EditarArquivo(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo");
            Console.WriteLine("-----------------------");
            string text = "";
            do{
                text+= Console.ReadLine();
                text+= Environment.NewLine;

            }while(Console.ReadKey().Key != ConsoleKey.Escape);
            return text;

        }
        static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("  Onde deseja salvar?");
            var path = Console.ReadLine();
            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo salvo em {path} com sucesso!");

        }
        static void AbrirArquivo(){
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = "";
            try{
                path = Console.ReadLine();
            }catch{
                Console.WriteLine("Insira um caminho valido");
                Console.ReadKey();
                AbrirArquivo();
            }
            using(var file = new StreamReader(path)){
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("Fim do arquivo ...");
            Console.ReadKey();
            Menu();
        }

    }
}