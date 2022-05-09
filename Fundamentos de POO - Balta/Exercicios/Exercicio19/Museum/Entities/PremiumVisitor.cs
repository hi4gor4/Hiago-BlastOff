namespace Museum.Entities
{
    public class PremiumVisitor :Visitor
    {
        public PremiumVisitor(string name, string cpf, DateTime birthDate, byte themeCode, double mealTicket)
        :base(name, cpf, birthDate, themeCode)
        {
            MealTicket = mealTicket;
            CodeTicket = new Guid();
        }
        public double MealTicket { get; set; }
        public Guid CodeTicket { get; set; }

        public bool MakeMeal(double value){
            if(MealTicket > value){
                MealTicket -= value;
                return true;
            }
            return false;
        }
    }
}