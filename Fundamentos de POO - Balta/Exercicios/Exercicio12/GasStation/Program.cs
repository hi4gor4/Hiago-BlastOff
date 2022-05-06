
using FuelStation;
using FuelStationEnum;

namespace GasStation
{
    public class Prorgram
    {
        static void Main(string[] args)
        {
            GeralMenu();
        }
        static void GeralMenu()
        {
            Console.Clear();
            Console.WriteLine("Vamos cadastrar a bomba de combustivel");
            EFuelType fuelType = (EFuelType)GetFuelType();
            Console.Clear();
            double valueLiter = GetValueLiter();
            Console.Clear();
            double valueTank = GetTank();
            PumpMenu(new FuelPump(valueLiter,valueTank,fuelType));

        }
        static void PumpMenu(FuelPump fuelpump)
        {
            ScreenFuelPump.Show(fuelpump);
            Console.WriteLine("1 - Abastecer por valor");
            Console.WriteLine("2 - Abastecer Por litro");
            Console.WriteLine("3 - Alterar valor");
            Console.WriteLine("4 - Alterar conbustivel");
            Console.WriteLine("5 - Alterar quantidade de combustivel");
            Console.WriteLine("6 - Cadastrar nova bomba");
            Console.WriteLine("7 - Sair");
            uint option = ReadValidUint();
            switch(option){
                case 1:
                    Console.WriteLine("Insira a quantidade em dinheiro:");
                    double value = ReadValidDouble();
                    if(value <= fuelpump.Tank* fuelpump.ValueLiter && value > 0){
                        fuelpump.SupplyByValue(value);
                        Console.WriteLine("Abastecido com sucesso");
                    }else{
                        Console.WriteLine("Impossivel abastecer esse valor");
                    }
                    break;
                case 2:
                    Console.WriteLine("Insira a quantidade em litros:");
                    double liter = ReadValidDouble();
                    if(liter <= fuelpump.Tank&& liter > 0){
                        fuelpump.SupplyByLiter(liter);
                        Console.WriteLine("Abastecido com sucesso");
                    }else{
                        Console.WriteLine("Impossivel abastecer esse valor");
                    }
                    break;
                case 3:
                    Console.WriteLine("Insira o novo valor:");
                    double valueliter = ReadValidDouble();
                    if(valueliter > 0){
                        Console.WriteLine("Valor Alterado com sucesso");
                        fuelpump.ChangeLiterValue(valueliter);
                    }else{
                        Console.WriteLine("Impossivel atribuir um valor negativo para o combustivel");
                    }
                    break;
                case 4:
                    if(fuelpump.Tank == 0){
                        uint fueltype = GetFuelType();
                        fuelpump.ChangeFuelType((EFuelType)fueltype);
                        Console.WriteLine("Combustivel alterado com sucesso");
                    }else{
                        Console.WriteLine("Esvazie o tanque para mudar decombustivel");
                    }
                    break;
                case 5:
                    Console.Write("Insira a quantidade alterada:");
                    double fuel = ReadValidDouble();
                    if(fuel + fuelpump.Tank > 0){
                        fuelpump.ChangeTank(fuel);
                        Console.WriteLine("Valor Alterado!");
                    }else{
                        Console.WriteLine("Impossivel retirar essa quantidade de combustivel");
                    }
                    break;
                case 6:
                    GeralMenu();
                    break;
                case 7:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;   
            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            PumpMenu(fuelpump);
        }

        static uint ReadValidUint()
        {
            uint value =0;
            try{
                value = uint.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Valor Invalido, tente novamente");
                return ReadValidUint();
            }
            return value;
        }
        static uint GetFuelType()
        {
            Console.WriteLine("Insira o tipo de combustivel:");
            Console.WriteLine("1 -Gasolina");
            Console.WriteLine("2-Diesel");
            Console.WriteLine("3-Etanol");
            Console.WriteLine("4-Gas");
            uint fuelType = ReadValidUint();
            if(fuelType >0 &&fuelType <=4){
                return fuelType; 
            }
            Console.Clear();
            Console.WriteLine("O valor não corresponde a um combustivel");
            return GetFuelType();
        }

        static double GetValueLiter()
        {
            Console.Write("Insira o valor por litro de combustivel:");
            double valueLiter = ReadValidDouble();
            if(valueLiter >0){
                return valueLiter;
            }
            Console.Clear();
            Console.WriteLine("Valor Negativo, Tente novamente");
            return GetValueLiter();
        }
         static double GetTank()
        {
            Console.Write("Insira a quantidade de combustivel na bomba:");
            double valueLiter = ReadValidDouble();
            if(valueLiter >0){
                return valueLiter;
            }
            Console.Clear();
            Console.WriteLine("Valor Negativo, Tente novamente");
            return GetTank();
        }
        static double ReadValidDouble()
        {
            double value =0;
            try{
                value = double.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Valor Invalido, tente novamente");
                return ReadValidUint();
            }
            return value;
        }
    }

}