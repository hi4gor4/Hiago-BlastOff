namespace BankEntities
{
    public abstract class SavingsAccount : Account
    {
        public double Inconome { get; set; }

        public SavingsAccount(string number, int bankBranch, double balance,double inconome)
        :base(number, bankBranch,balance)
        {
            Inconome = inconome;
        }

        public double CalculateIncome(uint numberMonths)=> (Balance*Inconome*numberMonths);
        

    }
}