using System.Globalization;
namespace ValorPeixe
{
    class Program
    {
        static void Main(string[] args){
            Menu();
        }
        static void Menu(){
            uint pesoPeixe = verificaPeso();
            Peixe px = new Peixe(pesoPeixe);
            selectOptions(px);
        }
        static uint verificaPeso(){
            Console.Clear();
            Console.WriteLine("Bom dia Sr. João");
            Console.WriteLine("Qual foi o peso do seu peixe?");
            uint peso = 0;
            try{
                peso = uint.Parse(Console.ReadLine());   
            } catch{
                Console.WriteLine("Xiii seu joão isso ai parece papo de pescador, isso não é nem um peso!");
                Console.WriteLine("Aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                return verificaPeso();
            }
            return peso;
        }
        static void selectOptions(Peixe px){
            Console.Clear();
            Console.WriteLine("Para consultar o peso excedente tecle        1");
            Console.WriteLine("Para consultar o valor da multa tecle        2");
            Console.WriteLine("Para cadastrar um novo peixe tecle           3");
            Console.WriteLine("Para sair do programa tecle                  4");
            short seletor = 0;
            try{
                seletor  = short.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Opcão invalida, aperte qualquer tecla para tentar novamente");
                Console.ReadKey();
                selectOptions(px);
            }
            Console.Clear();
            switch(seletor){
                case 1:
                    Console.WriteLine("O peso excedente do seu peixe foi de "+ px.GetExcesso()+ "kg");
                    break;
                case 2:
                    Console.WriteLine("O valor da multa  foi de "+ px.getMulta().ToString("C2", CultureInfo.CurrentCulture));
                    break;
                case 3:
                    Menu();
                    break;
                case 4: 
                    Environment.Exit(0);
                    break;   
                default:
                    Console.WriteLine("Opção invalida");     
                    break;
            }
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
