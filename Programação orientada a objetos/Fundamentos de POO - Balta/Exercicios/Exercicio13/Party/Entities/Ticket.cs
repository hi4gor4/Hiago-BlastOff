namespace PartyEntities
{
    public abstract class Ticket
    {
        protected Ticket(double value)
        {
            Value = value;
        }
        public double Value { get; set; }


        public void PrintValue(){
            Console.WriteLine($"O ingresso curta{Value} ");
        }

    }
}