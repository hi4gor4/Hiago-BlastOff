namespace VerificaTriangulo
{
    public class Program
    {
        static void Main(string[] args){
            Menu();
            
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Vamos lá, eu posso descobrir se o numero que você deseja é um triangulo");
            Console.WriteLine("Para isso vou te pedir para me falar quais pontos definem seu triangulo");
            Console.WriteLine("Aperte Qualquer Tecla para continuar");
            Console.ReadKey();
            int rtA = GetPontoValido('a');
            int rtB = GetPontoValido('b');
            int rtC = GetPontoValido('c');
            if(new Triangulo(rtA, rtB, rtC).verificaTipo()){
                Console.WriteLine("Temos um triangulo valido");
            }else{
                Console.WriteLine("Não consigo formar um triangulo com essas retas");
            }
            Console.WriteLine("Quer tentar mais uma vez?");
            Console.WriteLine("Para tentar mais uma vez digite 1, ou qualquer tecla para sair");
            int seletor = 0;
            try{
                seletor = int.Parse(Console.ReadLine());
            }catch{
                Environment.Exit(0);
            }
            if(seletor == 1){
                Menu();
            }else{
                System.Environment.Exit(0);
            }
            
        }
        static int GetPontoValido(char rt){
            Console.Clear();
            int ponto;
            Console.WriteLine("Vamos lá me diga qual o valor do ponto "+rt+ ":");
            try{
                ponto  = int.Parse(Console.ReadLine());
            }catch{
                Console.Clear();
                Console.WriteLine("Poxa cara esse numero é invalido! Aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                return GetPontoValido(rt);
            }
            return ponto;


        }
    }
}
