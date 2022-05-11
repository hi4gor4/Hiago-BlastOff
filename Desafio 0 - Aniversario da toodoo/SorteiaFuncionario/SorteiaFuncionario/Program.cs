using ClosedXML.Excel;
using SorteiaFuncionario.Model;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sorteio = new Sorteio("Toodoo");
            AddFuncs(sorteio);
            Console.WriteLine(sorteio.Sortear());
            Console.WriteLine(sorteio.Funcionarios.Count());
        }

        private static void AddFuncs(Sorteio sorteio)
        {
            FileInfo fi = new FileInfo(@"C:\Users\hiago\Documents\Toodoo\blas\Hiago-BlastOff\Desafio 0 - Aniversario da toodoo\SorteiaFuncionario\SorteiaFuncionario\Lista_de_funcionarios.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(fi))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int coluna = 0;
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
    }
}