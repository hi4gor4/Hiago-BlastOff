namespace FinancialAgency
{
    public  class LegalEntityContract : Contract
    {
        public LegalEntityContract(int number, string contractor, float value, int term,string cnpj, string stateRegistration)
        :base(number, contractor, value, term)
        {
            Cnpj = cnpj;
            StateRegistration = stateRegistration;
        }

        public string Cnpj { get; set; }
        public string StateRegistration { get; set; }

        public override float CalculateInstallment()
        {
            return base.CalculateInstallment() +3 ;
        }
    }
}        