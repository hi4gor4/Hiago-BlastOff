
using DealershipEnums;
using UserSolicitor;
namespace DealershipControllers
{
    public class Dealership{
        public static void  MenuDealerShip()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a Locar, Concesionaria de veiculos");
            Console.WriteLine("1- Para saber mais sobre veiculos simples");
            Console.WriteLine("2- Para contratar veiculos premium");
            Console.WriteLine("3- Sair da loja");
            byte option = Solicitor.GetByteInterval(1,3);
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
            }
        }

        static void buyAutomobile()
        {
            Console.Clear();
            Console.WriteLine("Vamos fazer o orsamento do seu veiculo");
            Console.WriteLine("Para isso preciso saber de alguns dados do seu carro");
            Console.WriteLine("Primeiro quero saber qual tipo de combustivel");
            byte fuel = GetFuelType();
            Console.Clear();
        }

        static byte GetFuelType()
        {
            Console.WriteLine("1-Para veiculos a GASOLINA");
            Console.WriteLine("2-Para veiculos a ALCOOL");
            Console.WriteLine("3-Para veiculos a DIESEL");
            Console.WriteLine("4-Para veiculos a GAS");
            return Solicitor.GetByteInterval(1,4); 
            Console.WriteLine("Prossiga escolhendo a cor do seu veiculo");
            EColor color = GetEcolor()
        }
        static EColor GetEcolor()
        {
            Console.WriteLine("1-Para Branco");
            Console.WriteLine("2-Para Preto");
            Console.WriteLine("3-Para Azul");
            Console.WriteLine("4-Para Vermelho");
            Console.WriteLine("5-Para Prata");
            return (EColor) Solicitor.GetByteInterval(1,5);
        }
    }
}