using FuelStationEnum;

namespace FuelStation
{
    public class FuelPump
    {
        public FuelPump(double valueLiter, double tank, EFuelType fuelType)
        {
            ValueLiter = valueLiter;
            Tank = tank;
            FuelType = fuelType;
        }

        public double ValueLiter { get; set; }
        public double  Tank { get; set; }
        public EFuelType FuelType { get; set; }

        public bool SupplyByValue(double value){
            if(value/this.ValueLiter <= Tank){
                Tank -= (value/ValueLiter);
                return true;
            }
            return false;
        }
        public bool SupplyByLiter(double value){
            if(value <= Tank){
                Tank -= value;
                return true;
            }
            return false;
        }
        public void ChangeLiterValue(double literValue){
            this.ValueLiter = literValue;
        }

        public void ChangeFuelType(EFuelType fuelType){
            this.FuelType = fuelType;
        }

        public bool ChangeTank(double fuel){
            if(Tank + fuel > 0 ){
                Tank +=fuel;
                return true;
            }
            return false;
        }

    }
}