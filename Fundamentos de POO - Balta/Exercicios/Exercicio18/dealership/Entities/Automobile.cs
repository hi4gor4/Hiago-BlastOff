using DealershipEnums;

namespace DealerShipEntities
{
    class Automobile
    {
        public static byte GASOLINA = 1;
        public static byte ALCOOL = 2;
        public static byte DIESEL = 3;
        public static byte GAS = 4;

        public Automobile(byte fuel, EColor color, string model, string licensePlate)
        {
            Fuel = fuel;
            Color = color;
            Model = model;
            LicensePlate = licensePlate;
        }

        public byte Fuel { get; set; }
        public EColor Color { get; set; }
        public string Model { get; set; }

        public string LicensePlate  {get; set;}
        
        public  virtual double Cost(){
            if(Fuel == GASOLINA){
                return 12000;
            }else if(Fuel == ALCOOL){
                return 10500;
            }else if(Fuel == DIESEL){
                return 11000;
            }else if(Fuel == GAS){
                return 13000;
            }
            throw new IndexOutOfRangeException("O combustivel não é reconhecido");
        }
        

    
    }
}