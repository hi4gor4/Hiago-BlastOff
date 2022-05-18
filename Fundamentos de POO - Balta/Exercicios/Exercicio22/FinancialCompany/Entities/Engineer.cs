

namespace FinancialCompanyEntities
{
    public class Engineer : Employee
    {
        public Engineer()
        {
            
        }
        public Engineer(string name, string cpf, double salary, string crea, string category, string currentProject) 
        : base(name, cpf, salary)
        {
            Crea = crea;
            Category = category;
            CurrentProject = currentProject;
            
        }

        public string Crea  { get; set; }
        public string Category {get; set;}
        public string CurrentProject {get; set;}
      
        public override void AddBonus(){
            this.Salary += Salary * 0.05;
        } 
    }
}