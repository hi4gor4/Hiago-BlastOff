using System;

namespace GerenciadorComissional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Sistema de cadastro comissional");
            Console.WriteLine("Favor insira o nome da empresa");
            Empresa emp = new Empresa(validaNome());
            short opt = 0;
            do{
                opt = opcoesMenu();
                switch(opt){
                    case 1:
                        Console.WriteLine("Favor insira o nome do funcionario");
                        string nome  = validaNome();
                        double comisao  = validaComissao(nome);
                        emp.AddFuncionario(nome, comisao);
                        break;
                    case 2:
                        short optComissionados = verificaFaixa();
                        Console.WriteLine($"{emp.verificaFaixa(optComissionados)} recebem nessa faixa de preço");
                        Console.WriteLine("São eles:");
                        Console.WriteLine(emp.ToString(optComissionados));
                        Console.ReadKey();
                        
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção invalida, pressione qualquer tecla para tentar novamente");
                        Console.ReadKey();
                        break;    
                }
            }while(true); 
            
        }

        static short opcoesMenu(){
            Console.Clear();
            Console.WriteLine("Para adicionar um funcionario tecle                          1");
            Console.WriteLine("Para verificar comissionados por faixa de valor tecle        2");
            Console.WriteLine("Para sair tecle                                              3");
            return validaOption();

        }
        static short validaOption(){
            short option = 0;
            try{
                option = short.Parse(Console.ReadLine());
            }catch{
                Console.Clear();
                Console.WriteLine("Favor insira um valor valido...");
                return validaOption();
            }
            return option;
        }
        static string validaNome(){
            string nome = " ";
            nome = Console.ReadLine();
            if(nome == null){
                Console.WriteLine("Favor insira um nome valido");
                return validaNome();
            }
    
            return nome;
        }
        static double validaComissao(string nome){
            Console.Clear();
            Console.WriteLine($"Favor insira a comissão do(a) {nome}: ");
            double db = 0;
            try{
                db = double.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Valor invalido, pressione qualquer tecla para tentar novamente");
                Console.ReadKey();
                return validaComissao(nome);
            }
            if(db>=0){
                return 200 + db*0.09;
            }else{
                Console.WriteLine("Valor invalido, pressione qualquer tecla para tentar novamente");
                Console.ReadKey();
                return validaComissao(nome);
            }


        }
        static short verificaFaixa(){
            Console.Clear();
            for(int i = 1; i <=8;i++ )
                Console.WriteLine($"Para verificar os comicionados que recebem {i+1}00 a {i+1}99 tecle     {i}");
            Console.WriteLine("Para comissionados que recebem 1000 ou mais tecle                     9"); 
            short valor = validaOption();
            if(valor > 0 && valor <10){
                return valor;
            }   
            Console.WriteLine("Valor invalido, pressione qualquer tecla para tentar novamente");
            Console.ReadKey();
            return verificaFaixa();

        }
    }
}