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
        public Contract()
        {
            
        }

        public int Number { get; set; }

        public string Contractor {get; set;}

        public float Value { get; set; }
        
        public int Term { get; set; }

        public virtual float CalculateInstallment() => Value/Term;

        static float GetPrestacao<T> (ref T x, Contract contract)
        {
            IndividualContract ind = new IndividualContract();
            if(x.GetType()== ind.GetType()){
                ind = (IndividualContract) contract;
                return ind.CalculateInstallment();
            }else{
                LegalEntityContract leg = (LegalEntityContract) contract;
                return leg.CalculateInstallment();
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"O contrato tem {Value} e um prazo de {Term}"); 
        }

    }
}