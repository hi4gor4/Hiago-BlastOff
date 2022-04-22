namespace CalcSalario
{
    class Salario{
        private double salarioBruto;
        private uint horas;
        private double valorHora;
        private short irPercentual;
        private double ir;
        private double salarioLiquido;
        private double inss;
        public Salario(uint horas, double valorHora){
            this.horas = horas;
            this.valorHora = valorHora;
            this.salarioBruto = horas* valorHora;
            if(this.salarioBruto <=900){
                this.irPercentual = 0;
                this.ir= 0;
            }else if(salarioBruto<=1500){
                this.irPercentual = 5;
                this.ir = salarioBruto * 0.05;
            }else if(salarioBruto <=2500){
                this.irPercentual = 10;
                this.ir = salarioBruto*0.1;
            }else{
                this.irPercentual = 20;
                this.ir = salarioBruto * 0.2;
            }
            this.inss = salarioBruto*0.1;
            salarioLiquido = salarioBruto - ir - inss;
        }
        public double GetSalarioBruto(){
            return this.salarioBruto;
        }   
        public double GetSalarioLiquido(){
            return this.salarioLiquido;
        } 

        public uint getHoras(){
            return this.horas;
        } 

        public double GetValorHora(){
            return this.valorHora;
        } 

        public double GetIr(){
            return this.ir;
        } 

        public short GetIrPercentual(){
            return this.irPercentual;
        } 
        public double GetInss(){
            return this.inss;
        } 
    }
}