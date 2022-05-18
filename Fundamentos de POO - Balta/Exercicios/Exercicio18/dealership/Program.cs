
using DealerShipEntities;
using DealershipEnums;
using UserSolicitor;
namespace DealershipControllers
{
    public class Dealership{

        static void Main(string[] args){
            MenuDealerShip();
        }
        public static void  MenuDealerShip()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a Locar, Concesionaria de veiculos");
            Console.WriteLine("1- Para saber mais sobre veiculos simples");
            Console.WriteLine("2- Para saber mais sobre veiculos premium");
            Console.WriteLine("3- Sair da loja");
            byte option = Solicitor.GetByteInterval(1,3);
            switch(option)
            {
                case 1:
                    BuyAutomobile();
                    break;
                case 2:
                    BuyPremiumAutomobile();
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }
        }


        static void BuyAutomobile()
        {
            Console.Clear();
            Console.WriteLine("Vamos fazer o orçamento do seu veiculo");
            Console.WriteLine("Para isso preciso saber de alguns dados do seu carro");
            Console.WriteLine("Primeiro quero saber qual tipo de combustivel");
            byte fuel = GetFuelType();
            Console.WriteLine("Prossiga escolhendo a cor do seu veiculo");
            EColor color = GetEcolor();
            Console.WriteLine("Insira o modelo co seu carro");
            string model = Solicitor.GetValidString();
            Console.WriteLine("Insira a placa do veiculo");
            Console.WriteLine("use o padrão ZZZ-0000");
            string licensePlate = Solicitor.GetValidPlate();
            Console.Clear();
            Console.WriteLine("Parabens pela sua escolha!");
            Automobile clientAutomobile = new Automobile(fuel, color, model, licensePlate);
            Console.WriteLine($"O {clientAutomobile.Model} de placa {clientAutomobile.LicensePlate} pode ser seu por apenas {clientAutomobile.Cost()}");
            Console.WriteLine("1-Para compralo");
            Console.WriteLine("2 Para tentar outro carro");
            byte option = Solicitor.GetByteInterval(1,2);
            if(option==1){
                Console.WriteLine("Parabéns pela escolha pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                System.Environment.Exit(0);
            }else{
                MenuDealerShip();
            }
        }

        static void BuyPremiumAutomobile()
        {
            Console.Clear();
            Console.WriteLine("Vamos fazer o orçamento do seu veiculo");
            Console.WriteLine("Para isso preciso saber de alguns dados do seu carro");
            Console.WriteLine("Primeiro quero saber qual tipo de combustivel");
            byte fuel = GetFuelType();
            Console.WriteLine("Prossiga escolhendo a cor do seu veiculo");
            EColor color = GetEcolor();
            Console.WriteLine("Insira o modelo co seu carro");
            string model = Solicitor.GetValidString();
            Console.WriteLine("Insira a placa do veiculo");
            Console.WriteLine("use o padrão ZZZ-0000");
            string licensePlate = Solicitor.GetValidPlate();
            Console.Clear();
            AutomobileDeluxe clientAutomobile = new AutomobileDeluxe(fuel, color, model, licensePlate);
            Console.WriteLine("Podemos incluir alguns adicionais no seu veiculo!");
            Console.WriteLine("Deseja adicionar Direção Hidraulica no seu veiculo?");
            Console.WriteLine("Digite 1 para sim e 2 para não");
            byte aditional = Solicitor.GetByteInterval(1,2);
            if(aditional== 1)
                clientAutomobile.AirConditioning = true;
            
            Console.WriteLine("Deseja adicionar Direção Hidraulica no seu veiculo?");
            Console.WriteLine("Digite 1 para sim e 2 para não");
            aditional = Solicitor.GetByteInterval(1,2);
            if(aditional ==1)
                clientAutomobile.HydraulicSteering= true;

            Console.WriteLine("Deseja adicionar Vidros eletricos no seu veiculo?");
            Console.WriteLine("Digite 1 para sim e 2 para não");
            aditional = Solicitor.GetByteInterval(1,2);
            if(aditional ==1)
                clientAutomobile.ElectricGlass= true; 
            Console.Clear();   
            Console.WriteLine("Parabens pela sua escolha!");
            Console.WriteLine($"O {clientAutomobile.Model} de placa {clientAutomobile.LicensePlate} pode ser seu por apenas {clientAutomobile.Cost()}");
            Console.WriteLine("1-Para compralo");
            Console.WriteLine("2 Para tentar outro carro");
            byte option = Solicitor.GetByteInterval(1,2);
            if(option==1){
                Console.WriteLine("Parabéns pela escolha pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                System.Environment.Exit(0);
            }else{
                MenuDealerShip();
            }
        }
        
        static byte GetFuelType()
        {
            Console.WriteLine("1-Para veiculos a GASOLINA");
            Console.WriteLine("2-Para veiculos a ALCOOL");
            Console.WriteLine("3-Para veiculos a DIESEL");
            Console.WriteLine("4-Para veiculos a GAS");
            return Solicitor.GetByteInterval(1,4); 

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