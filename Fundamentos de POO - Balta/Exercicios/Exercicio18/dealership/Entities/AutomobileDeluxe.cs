using DealershipEnums;

namespace DealerShipEntities
{
    class AutomobileDeluxe : Automobile
    {
        
        public AutomobileDeluxe(byte fuel, EColor color, string model, string licensePlate)
        :base(fuel, color, model, licensePlate)
        {
            AirConditioning = false;
            ElectricGlass = false;
            HydraulicSteering = false;
        }
        public bool AirConditioning { get; set; }
        public bool HydraulicSteering {get; set;}
        public bool ElectricGlass {get; set;}

        public  override double Cost(){
           var cost = base.Cost();
            if(AirConditioning)
                cost+=2000;
            if(HydraulicSteering)
                cost+=1500;
            if(ElectricGlass)
                cost+= 800;
            return cost;
        }
    
    }
}