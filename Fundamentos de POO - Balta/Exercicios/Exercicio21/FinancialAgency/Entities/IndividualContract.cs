namespace FinancialAgency
{
    public  class IndividualContract : Contract
    {
        public IndividualContract(int number, string contractor, float value, int term,string cpf, int age)
        :base(number, contractor, value, term)
        {
            Cpf = cpf;
            Age = age;
        }

        public string Cpf { get; set; }
        public int Age { get; set; }
        public override float CalculateInstallment()
        {
            int additional = 0 ;
            if(Age <=30){
                additional=1;
            }else if(Age <=40){
                additional =2;
            }else if(Age<=50){
                additional =3;
            }else{
                additional =4;
            }
            return base.CalculateInstallment()+ additional;
        }
        //ANCHOR fazer polimorfismo da classe
    }
}        