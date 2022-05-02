namespace CompeticaoSalto
{
    class Saltador
    {
        private string nome;
        private double[] salto;
        

        public string GetNome(){
            return this.nome;
        }
        public double GetSaltoMedia(){
            Array.Sort(this.salto);
            return (this.salto[1]+ this.salto[2]+this.salto[3])/3;
        }
        public double GetSalto(short num){
            return this.salto[num-1];
        }
        public double getMelhorSalto(){
            Array.Sort(this.salto);
            return this.salto[4];
        }
 
        public double getPiorSalto(){
            Array.Sort(this.salto);
            return this.salto[0];
        }

        public  Saltador(string nome, double[] saltos){
            this.salto = saltos;
            this.nome = nome;
        }
    }
}