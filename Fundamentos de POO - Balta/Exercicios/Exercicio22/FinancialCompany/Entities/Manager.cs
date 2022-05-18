

namespace FinancialCompanyEntities
{
    public class Manager : Employee
    {
        public Manager()
        {
            
        }
        public Manager(string name, string cpf, double salary, float specialPassword, int numEmployees) 
        : base(name, cpf, salary)
        {
            SpecialPassword = specialPassword;
            NumEmployees = numEmployees;    
        }

        private float SpecialPassword  { get; set; }
        private int   NumEmployees {get; set;}
        public override void AddBonus()
        {
            Salary += Salary*0.1;
        }
    }
}