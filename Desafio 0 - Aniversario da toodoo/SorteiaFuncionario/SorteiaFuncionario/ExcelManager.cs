using OfficeOpenXml;
namespace SorteiaFuncionario.Planilha
{
    public static class ExcelManager
    {
        public static List<string> GetLinhas(int coluna, string path)
        {
            List<string> response = new List<string>();
            FileInfo fi = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(fi))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int numeroLinhas = worksheet.Dimension.End.Row;
                string conteudo = "";
                for(int linha = 2; linha<= numeroLinhas; linha++)
                {
                    conteudo = worksheet.Cells[linha, coluna].Value.ToString();
                    if(conteudo != null)
                        response.Add(conteudo);
                }
            }
            return response;
        }

        public static void AddLinha(int coluna, string path, string value)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if(!File.Exists(path)){
                ExcelPackage excel = new ExcelPackage();
                var tabela = excel.Workbook.Worksheets.Add("plan1");
                tabela.Cells[1,1].Value = value;
                FileStream objFile = File.Create(path);
                objFile.Close();
                File.WriteAllBytes(path, excel.GetAsByteArray()); 
            }else{
                FileInfo fi = new FileInfo(path);
                ExcelPackage package = new ExcelPackage(fi);
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                int numeroLinhas = worksheet.Dimension.End.Row + 1 ;
                worksheet.InsertRow(numeroLinhas, 1);
                worksheet.Cells[numeroLinhas, coluna].Value = value;
                File.WriteAllBytes(path, package.GetAsByteArray());
            }  
        }
    }
}