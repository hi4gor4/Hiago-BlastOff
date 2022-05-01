namespace PartyEntities
{
    public class UpperCabin : Vip
    {
        public double UpperAdditional { get; set; }
        public UpperCabin(double value, double additionalValue, double upperAdittional) 
        : base(value, additionalValue)
        {
            UpperAdditional = upperAdittional;
        }
    }
}