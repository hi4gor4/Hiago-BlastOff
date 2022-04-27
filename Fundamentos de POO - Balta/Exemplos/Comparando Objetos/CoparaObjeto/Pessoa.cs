namespace MyApp{
    public class Pessoa: IEquatable <Pessoa>
    {
        public int id { get; set; }

        public Pessoa(int id){
            this.id = id;
        }
        public bool Equals(Pessoa? other)//apos implementado através do equals podemos verificar a igualdade entre dois objetos
        {
            return this.id ==  other.id;
        }
    }
}