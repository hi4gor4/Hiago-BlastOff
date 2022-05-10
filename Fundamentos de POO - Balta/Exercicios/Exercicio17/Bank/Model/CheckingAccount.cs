namespace BankEntities
{
    public abstract class CheckingAccount : Account
    {
        private double MonthlyPayment { get; set; }

        public CheckingAccount(string number, int bankBranch, double balance,double monthlyPayment)
        :base(number, bankBranch,balance)
        {
            MonthlyPayment = monthlyPayment;
        }

        public bool DeductsMonthlyFee(){
            if(Balance >= MonthlyPayment){
                Balance = Balance-MonthlyPayment;
                return true;
            }
            return false;
        }
        
        

    }
}