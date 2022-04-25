using System;

namespace ValidaCPF // Note: actual namespace depends on the project name.
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
                Console.WriteLine("Para verificar um cpf tecle          1");
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
                    PedeCpf();
                }else if (opt ==2){
                    Console.Clear();
                    Environment.Exit(0);
                }else{
                    Console.WriteLine("Favor insira uma opção valida, pressione qualquer tecla para prosseguir");
                    Console.ReadKey();
                }
            }    
        }
        static void PedeCpf(){
            Console.Clear();
            Console.WriteLine("Favor insira o cpf no formato: 000.000.000-00");
            string cpf = Console.ReadLine();
            Validador valid = new Validador();
            if(cpf != null && valid.validaFormato(cpf) ){
                if(valid.ValidaCPF(cpf)){
                    Console.WriteLine($"O cpf {cpf} é valido");
                }else{
                    Console.WriteLine($"O cpf {cpf}  não é valido");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar");
            }else{
                Console.WriteLine("O cpf não corresponte ao padrão desejado, pressione qualquer tecla para tentar novamente...");
            
            }
                Console.ReadKey();
        }
    }
}