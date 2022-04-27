namespace MyApp{
    internal class Program{
        static void main(string[] args){
            var pessoaUm =new Pessoa(1);
            var pessoaDois = new Pessoa(1);
            Console.WriteLine(pessoaDois== pessoaUm);//false pois compara os endereços
            Console.WriteLine(pessoaUm.Equals(pessoaDois));//true pois compara os objetos
        }
    }
}