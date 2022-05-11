using UserSolicitor;
using SorteiaFuncionario.Model;
using OfficeOpenXml;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sorteio = new Sorteio("Toodoo");
            AddFuncs(sorteio);
            Menu(sorteio);
        }

        private static void AddFuncs(Sorteio sorteio)
        {
            FileInfo fi = new FileInfo(@"C:\Users\hiago\Documents\Toodoo\blas\Hiago-BlastOff\Desafio 0 - Aniversario da toodoo\SorteiaFuncionario\SorteiaFuncionario\Lista_de_funcionarios.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(fi))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.End.Row;
                string nome = "";
                int id = 0;
                for(int row = 2; row<= rowCount; row++)
                {
                    nome = worksheet.Cells[row, 1].Value.ToString();
                    id++;
                    sorteio.AddFuncionario(new Funcionario(nome, id));
                }
            }
        }
        static void Menu(Sorteio sorteio)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Sorteio de funcionarios TooDoo");
            Console.WriteLine("1- Para sortear um nome");
            Console.WriteLine("2- Ver participantes");
            Console.WriteLine("3- Para sair");
            byte option = Solicitor.GetByteInterval(1,3);
            Console.Clear();
            switch(option)
            {
                case 1:
                    Console.WriteLine(sorteio.Sortear());
                    break;
                case 2:
                    PrintFuncionarios(sorteio);
                    break;
                case 3:
                    Console.Clear();
                    System.Environment.Exit(0);
                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para prosseguir");
            Console.ReadKey();
            Menu(sorteio);
        }
        static void PrintFuncionarios(Sorteio sorteio)
        {
            foreach (var func in sorteio.Funcionarios)
            {
                Console.WriteLine(func);
            }
            Console.WriteLine($"São {sorteio.Funcionarios.Count}");
        }
    }
}