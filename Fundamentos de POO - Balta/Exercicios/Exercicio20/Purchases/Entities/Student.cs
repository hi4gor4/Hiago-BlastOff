namespace PurchasesEntities
{
    public class Student:Purchase
    {
        public Student(double price, short installment, string type)
        :base(price, installment,type)
        {
            
        }
        public  bool PayInstallment()
        {
            return base.PayInstallment(1);
        }
        public override void removePurchase()
        {
            this.Price = 0;
            base.removePurchase();
        }
    }
}