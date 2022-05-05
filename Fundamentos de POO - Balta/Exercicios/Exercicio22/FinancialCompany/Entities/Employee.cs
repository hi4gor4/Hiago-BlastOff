namespace FinancialCompanyEntities
{
    public class EMployee
    {
        public string  Name { get; set; }
        public string Cpf { get; set; }
        public double Salary {get; set;}

        public double CalculateBonus(double percentage){
            return Salary+Salary*percentage;
        }
    }
}