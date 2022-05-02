namespace PartyEntities
{
    public  class Vip : Ticket
    {
        public Vip(double value ,double additionalValue)
        :base(value)
        {
            AdditionalValue = additionalValue;
        }

        public double AdditionalValue  { get; set; }

        public double TotalValue()=>  Value+AdditionalValue; 


    }
}