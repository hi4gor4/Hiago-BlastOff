namespace Museum.Entities
{
    public class PremiumVisitor :Visitor
    {
        public PremiumVisitor(string name, string cpf, DateTime birthDate, byte themeCode)
        :base(name, cpf, birthDate, themeCode)
        {
            MealTicket = 100;
        }
        public double MealTicket { get; set; }

        public bool MakeMeal(double value){
            if(MealTicket > value){
                MealTicket -= value;
                return true;
            }
            return false;
        }
    }
}