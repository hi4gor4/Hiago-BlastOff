namespace FinancialAgency
{
    public abstract class Contract
    {
        protected Contract(int number, string contractor, float value, int term)
        {
            Number = number;
            Contractor = contractor;
            Value = value;
            Term = term;
        }

        public int Number { get; set; }

        public string Contractor {get; set;}

        public float Value { get; set; }
        
        public int Term { get; set; }

        public virtual float CalculateInstallment() => Value/Term;

    }
}