namespace ValorPeixe{
    public class Peixe{
        private uint excesso;
        private decimal multa;
        public Peixe(uint peso){
            if(peso>50){
                this.excesso = peso-50;
                this.multa = 4*(peso-50);
            }else{
                this.multa = 0;
                this.excesso = 0; 
            }
        }
        public uint GetExcesso(){
            return this.excesso;
        }
        public decimal getMulta(){
            return this.multa;
        }
    }

}