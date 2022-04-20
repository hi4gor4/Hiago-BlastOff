namespace RandonNumber{
    public class Akinator{
        private int number;
        private int escopo;

        public Akinator(int escopo)
        {
            Random randNum = new Random();
            this.escopo = escopo;
            this.number = randNum.Next(0,escopo);
        }
        public  bool VerificaNumber(int num){
            return num == this.number;
        }
        public  bool VerificaEscopo(int num){
            return num >= 0 && num <=this.escopo;
        }


    }
}