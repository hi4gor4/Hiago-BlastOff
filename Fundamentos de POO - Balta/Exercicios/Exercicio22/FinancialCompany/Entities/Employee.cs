namespace FinancialCompanyEntities
{
    public class Employee
    {
        public Employee()
        {
            
        }
        public Employee(string name, string cpf, double salary)
        {
            Name = name;
            Cpf = cpf;
            Salary = salary;
        }

        public string  Name { get; set; }
        public string Cpf { get; set; }
        public double Salary {get; set;}

        public double CalculateBonus(double percentage){
            return Salary+Salary*percentage;
        }
        public virtual void  AddBonus()
        {
           
        }
    }
}