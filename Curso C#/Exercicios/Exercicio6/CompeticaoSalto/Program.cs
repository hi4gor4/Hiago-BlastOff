namespace CompeticaoSalto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("Competicao de salto");
            string nome = RegistraNome();
            double[] saltos = new double[5]; 
            for(short i=0; i<5; i++){
                saltos[i] = RegistraSalto(i);

            }
            Saltador saltador = new Saltador(nome, saltos);
            Console.WriteLine($"Atleta:{saltador.GetNome()} ");
            Console.WriteLine($"\nPrimeiro Salto: {saltador.GetSalto(1).ToString("F1")}m");
            Console.WriteLine($"Segundo Salto: {saltador.GetSalto(2).ToString("F1")}m");
            Console.WriteLine($"Terceiro Salto: {saltador.GetSalto(3).ToString("F1")}m");
            Console.WriteLine($"Quarto Salto: {saltador.GetSalto(4).ToString("F1")}m");
            Console.WriteLine($"Quinto Salto: {saltador.GetSalto(5).ToString("F1")}m");

            Console.WriteLine("\n\n");

            Console.WriteLine($"Melhor Salto: {saltador.getMelhorSalto().ToString("F1")}m");
            Console.WriteLine($"Pior Salto: {saltador.getPiorSalto().ToString("F1")}m");
            Console.WriteLine($"Media dos demais saltos {saltador.GetSaltoMedia().ToString("F1")}m");

            Console.WriteLine("Resultado final");
            Console.WriteLine($"{saltador.GetNome()}: {saltador.GetSaltoMedia().ToString("F1")}m");

            Console.WriteLine("\n\n\nPara encerrar o programa tecle 1, ou qualquer tecla para continuar");
            ushort seletor = 0;
            try{
                seletor = ushort.Parse(Console.ReadLine());
            }catch{
                
                Menu();
            }
            if(seletor ==1)
                System.Environment.Exit(0);
            Menu();
        }
        static string RegistraNome(){
            Console.WriteLine("Favor insira seu nome");
            string nome = "";
            try{
                nome = Console.ReadLine();
            }catch{
                Console.WriteLine("Impossivel definir seu nome, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                return RegistraNome();
            }
            if(nome == null){
                Console.WriteLine("Impossivel definir seu nome, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                return RegistraNome();
            }
            Console.Clear();
            return nome;
        }
        static double RegistraSalto(short num){
            Console.Clear();
            Console.WriteLine($"Favor insira a distancia do seu salto {num}");
            double distancia= 0;
            try{
                distancia = double.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Impossivel Definir a distancia, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                return RegistraSalto(num);
            }
            if(distancia <=0){
                Console.WriteLine("Impossivel Definir a distancia, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                return RegistraSalto(num);
            }
            return distancia;
        }

    }
}