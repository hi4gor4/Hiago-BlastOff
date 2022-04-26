using System;

namespace ValidaNome // Note: actual namespace depends on the project name.
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
                Console.WriteLine("Para verificar um nome tecle         1");
                Console.WriteLine("Para sair tecle                      2");
                short opt = 0;
                try{
                    opt = short.Parse(Console.ReadLine());
                }catch{
                    Console.WriteLine("Favor insira uma opção valida, pressione qualquer tecla para prosseguir");
                    Console.ReadKey();
                    Menu();
                }
                if(opt == 1){
                    PedeNome();
                }else if (opt ==2){
                    Console.Clear();
                    Environment.Exit(0);
                }else{
                    Console.WriteLine("Favor insira uma opção valida, pressione qualquer tecla para prosseguir");
                    Console.ReadKey();
                }
            }    
        }
        static void PedeNome(){
            Console.Clear();
            Console.WriteLine("Favor insira um nome:");
            string nome = Console.ReadLine();
            VerificadorNominal nm = new VerificadorNominal();
            if(nome != null && nm.ValidarNome(nome)){
                OpcoesNome(nome, nm);
            }else{
                Console.WriteLine("Favor insira um nome valido, pressione qualquer tecla para prosseguir...");
                Console.ReadKey();
                PedeNome();
            }
        }
        static void OpcoesNome(string nome, VerificadorNominal verificador){
            short opt = 0;
            do{
                Console.Clear();
                Console.WriteLine("Para ver o nome com todas as letras em maiusculo tecle           1");
                Console.WriteLine("Para ver o nome com todas as letras em minusculo tecle           2");
                Console.WriteLine("Para contar o numero de letras do nome tecle                     3");
                Console.WriteLine("Para contar o numero de letras do primeiro nome tecle            4");
                Console.WriteLine("Para SAIR tecle                                                  5");
                try{
                    opt = short.Parse(Console.ReadLine());
                }catch{
                    Console.WriteLine("Opção invalida, pressione qualquer tecla para prosseguir");
                    Console.ReadKey();
                    OpcoesNome(nome, verificador);
                }
                Console.Clear();
                switch(opt){
                    case 1:
                        Console.WriteLine(verificador.Maiusculo(nome));
                        break;
                    case 2:
                        Console.WriteLine(verificador.Minusculo(nome));
                        break;
                    case 3:
                        Console.WriteLine($"O nome tem: {verificador.ConteNome(nome)}");
                        break;
                    case 4:
                        Console.WriteLine($"O primeiro nome tem {verificador.ContePrimeiroNome(nome)}");     
                        break;       
                    case 5:
                        Menu();
                        break;
                    default:
                        Console.Write("Opção invalida,");
                        break;
                }
                    Console.WriteLine("Pressione qualquer tecla para prosseguir");
                    Console.ReadKey();
            }while(opt!=5);
        }
    }

}