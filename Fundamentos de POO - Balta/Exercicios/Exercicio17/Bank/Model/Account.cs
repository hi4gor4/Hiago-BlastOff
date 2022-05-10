namespace BankEntities
{
    public abstract class Account
    {
        protected Account(string number, int bankBranch, double balance)
        {
            Number = number;
            BankBranch = bankBranch;
            Balance = balance;
        }

        public string Number { get; set; }
        public int BankBranch { get; set;}

        protected double Balance { get; set;} 

        public bool MakeDeposit(double deposit)
        {
            if(deposit > 0){
                Balance += deposit;
                return true;
            }
            return false;
        }
        public bool MakeWithdrawal(double widthdrawal)
        {
            if(Balance - widthdrawal >= 0){
                Balance -= widthdrawal;
                return true;
            }
            return false;
        }
        public double GetBalance() => Balance;
    }
}