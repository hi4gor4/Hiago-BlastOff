namespace PurchasesEntities
{
    public class Purchase
    {
        public Purchase(double price, short installment, string type)
        {
            Price = price;
            Installment = installment;
            Type = type;
        }

        public double Price { get; set; }
        public short Installment { get; set; }
        public string Type { get; set; }

        public virtual bool PayInstallment(short value)//ANCHOR verificar se desconta o numero de parcela / valor total
        {
            if(Installment>= value){
                Installment -=value;
                return true;
            }
            return false;
        }

        public virtual void removePurchase()=> Installment = 0;

        public void CancelPurchase()
        {
            this.removePurchase();
            Console.WriteLine("Compra cancelada");//ANCHOR ver maneira de não printar na classe
        }

        public void UpdateInstallment(double interetRate, short numberInstallments )
        {
            Installment = numberInstallments;
            Price += Price*interetRate;

        }

    }
}