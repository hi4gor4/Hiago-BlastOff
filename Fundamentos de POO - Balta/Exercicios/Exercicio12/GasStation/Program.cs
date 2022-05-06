
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