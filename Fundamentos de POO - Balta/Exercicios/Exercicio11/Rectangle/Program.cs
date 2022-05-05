using System;
using RectangleEntities;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Insira as medidas do local");
            Console.WriteLine("Favor insira o Comprimento do local");
            double length = GetValidDouble();
            Console.WriteLine("Favor Insira a Largura do local");
            double width = GetValidDouble();
            HandleOptions(new Floor(length,width));

        }
        static void HandleOptions(Floor floor){
            short selector = 0;
            while(selector != 3){
                Console.Clear();
                Console.WriteLine("Para calcular os pisos tecle                         1");
                Console.WriteLine("Para Calcular o numero de rodapés gastos tecle       2");
                Console.WriteLine("Para cadastrar um novo local tecle                   3");
                Console.WriteLine("Para SAIR tecle                                      4");
                selector = GetValidShort();
                switch(selector){
                    case 1:
                        Tile tile = RegisterTile();
                        Console.Clear();
                        Console.WriteLine($"Para colocar piso no local serão necessarios {floor.CalculateTilesNumber(tile)}");
                        WaitUser();
                        break;
                    case 2:
                        BaseBoard baseboard = RegisterBaseboard();
                        Console.Clear();
                        Console.WriteLine($"Para colocar o rodape nessa area sao necessarios {floor.CalculateBaseboard(baseboard)} ");
                        WaitUser();
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    default:
                        NotifyInvalidValue();
                        break;                   
                }
            }
            Menu();
            
        }
        static double GetValidDouble(){
            double value = 0;
            try{
                value = double.Parse(Console.ReadLine());
            }catch{
                NotifyInvalidValue();
                return GetValidDouble();
            }
            if(value>0){
                return value;
            }else{
                NotifyInvalidValue();
                return GetValidDouble();
            }
        }
        static short GetValidShort(){
            short value = 0;
            try{
                value = short.Parse(Console.ReadLine());
            }catch{
                NotifyInvalidValue();
                return GetValidShort();
            }
            return value;
        }
        static void NotifyInvalidValue(){
            Console.WriteLine("O valor inserido não é valido");
            Console.WriteLine("Pressione Qualquer Tecla para tentar novamente");
            Console.ReadKey();
        }

        static Tile RegisterTile(){
            Console.Clear();
            Console.WriteLine("Favor insira o cumprimento do piso");
            double length = GetValidDouble();
            Console.WriteLine("Favor Insira a Largura do piso");
            double width = GetValidDouble();
            return new Tile(length, width);

        }
        static BaseBoard RegisterBaseboard(){
            Console.Clear();
            Console.WriteLine("Favor insira o cumprimento do Rodapé");
            double length = GetValidDouble();
            return new BaseBoard(length);

        }
        
        static void WaitUser()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}