using UserSolicitor;
using SorteiaFuncionario.Model;
using OfficeOpenXml;
using SorteiaFuncionario.Planilha;

namespace Program
{
    public class Program
    {
        public static string SORTEADOS = "sorteados.xlsx";
         public static string PARTICIPANTES = "Lista_de_funcionarios.xlsx";
        static void Main(string[] args)
        {
            var sorteio = new Sorteio("Toodoo");
            AddFuncs(sorteio);

            if(ExcelManager.VerifyTable(Path.GetFullPath(SORTEADOS)))
            AddSorteados(sorteio);
            Menu(sorteio);
        }

        private static void AddFuncs(Sorteio sorteio)
        {
            string path = Path.GetFullPath("Lista_de_funcionarios.xlsx");
            List<string> funcionarios = ExcelManager.GetLinhas(1,path);
            if(funcionarios.Count()==0 ){
                throw new Exception("Impossivel adicionar participantes");
            }
            foreach(string nome in funcionarios){
                sorteio.AddFuncionario(nome);
            }
        }
        static void Menu(Sorteio sorteio)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Sorteio de funcionarios TooDoo");
            Console.WriteLine("1- Para sortear um nome");
            Console.WriteLine("2- Ver participantes");
            Console.WriteLine("3-Ver sorteados");
            Console.WriteLine("4- Para sair");
            byte option = Solicitor.GetByteInterval(1,4);
            Console.Clear();
            switch(option)
            {
                case 1:
                    string sorteado = sorteio.Sortear();
                    string path = Path.GetFullPath("Sorteados.xlsx");
                    ExcelManager.AddLinha(1, path, sorteado);
                    Console.WriteLine(sorteado);
                    break;
                case 2:
                    PrintFuncionarios(sorteio);
                    break;
                case 3:
                    PrintSorteados(sorteio);
                    break;                
                case 4:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            Menu(sorteio);
        }
        static void AddSorteados(Sorteio sorteio){
            string path = Path.GetFullPath("Sorteados.xlsx");
            List<string> funcionarios = ExcelManager.GetLinhas(1,path);
            foreach(string nome in funcionarios){
                sorteio.AddSorteado(nome);
            }
        }
        static void PrintFuncionarios(Sorteio sorteio)
        {
            foreach (var func in sorteio.Funcionarios)
            {
                Console.WriteLine(func);
            }
            Console.WriteLine($"São {sorteio.Funcionarios.Count} participantes");
        }
        static void PrintSorteados(Sorteio sorteio)
        {
            foreach (var sorteados in sorteio.Sorteados)
            {
                Console.WriteLine(sorteados);
            }
            Console.WriteLine($"São {sorteio.Sorteados.Count} sorteados");
        }

        static void SorteiaFuncionario()
        {
            
        }
    }
}