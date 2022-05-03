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
    }
}