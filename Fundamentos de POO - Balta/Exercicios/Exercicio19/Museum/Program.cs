using Museum.Entities;
using UserSolicitor;
namespace MyApp 
{
    public class Program{
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Sistema de visitação");
            Console.WriteLine("1- Para cadastrar uma visita comun");
            Console.WriteLine("2- Para cadastrar uma vista simples");
            Console.WriteLine("3- Para sair");
            int option = Solicitor.GetValidInt();
            switch(option)
            {
                case 1:
                    break;
                case 2: 
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Favor insira uma opção valida");
                    break;
            }
        }
        static void CommonVisit()
        {
            Console.Clear();
            Console.WriteLine("Favor insira o seu nome");
            string name = Solicitor.GetValidName();
            Console.WriteLine("Favor Insira seu cpf");
            string cpf = Solicitor.GetValidString();
            //ANCHOR Criar solicitor de cpf usando o exercicio 11 de c#
            Console.WriteLine("Favor insira uma data valida");
            Console.WriteLine("Use o padrão dd/mm/aaaa");
            DateTime birthDate = Solicitor.getValidDate();
            byte attraction = MenuAttractions();
             
        }
        static byte MenuAttractions(){
            Console.Clear();
            Console.WriteLine("Agora Prossiga para escolher as atrações");
            Console.WriteLine("1- Para visitar a exposição VINTAGE ");
            Console.WriteLine("2- Para conhecer a exposição de NUMISMATICA");
            Console.WriteLine("3- Para conhecer a exposição de HISTORIA DA MUISCA");
            Console.WriteLine("4- Para conhecer a exposição de PINTURAS");
            Console.WriteLine("5- Para conhecer a exposição de ESCULURAS");
            Console.WriteLine("6- Para consultar o numero de atrações de uma exposição");
            var option = Solicitor.GetByteInterval(1,6);
            if(option == 6){
                Console.WriteLine("Insira o numero da exposição que você quer consultar o numero de atrações");
                var atraction = Solicitor.GetByteInterval(1,5);
                Console.WriteLine($"A atração {atraction} tem {Visitor.Attractions} atrações");
                Console.WriteLine("Para escolhela tecle 1, ou 0 para escolher outra");
                option = Solicitor.GetByteInterval(0,1);
                if(option == 0){
                    return MenuAttractions();
                }else{
                    return atraction;
                }
            }
            return option;
        }

        static void MenuVisitor(Visitor visitor){
            ViewVisit(visitor);
            Console.WriteLine("Deseja fazer outra visita");
            Console.WriteLine("1- Para sim");
            Console.WriteLine("2- Para sair");
        }
        static void ViewVisit(Visitor visitor)
        {
            foreach(var visitorTheme in visitor.Themes)
            {
                Console.Write($"Você visitou o tema ");
                switch(visitorTheme)
                {
                    case 1:
                        Console.WriteLine("VINTAGE");
                        break;
                    case 2:
                        Console.WriteLine("NUMISMATICA");
                        break;
                    case 3:
                        Console.WriteLine("HISTORIA DA MUSICA");
                        break;
                    case 4:
                        Console.WriteLine("PINTURA");
                        break;
                    case 5:
                        Console.WriteLine("ESCULTURAS");
                        break;
                }
            }
        }
    }
}