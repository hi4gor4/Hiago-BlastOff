using System.Globalization;
namespace CalcSalario
{
    class Program
    {
        static void Main(string[] args){
            VerificaSalario();
        }
        static void VerificaSalario(){
            Console.Clear();
            Console.WriteLine("Sistema de Calculo Salarial");
            uint horaTrabalhada = GetHorasTrabalhadas();
            double valorPorHora = GetValorPorHora();
            var salario = new Salario(horaTrabalhada,valorPorHora);
            Console.WriteLine($"Salario Bruto: ({salario.GetValorHora()} * {salario.getHoras()}):{salario.GetSalarioBruto().ToString("C2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"(-)IR({salario.GetIrPercentual()}%): {salario.GetIr().ToString("C2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"(-)INSS(10%): {salario.GetInss().ToString("C2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"FGTS(11%): {(salario.GetSalarioBruto()*0.11).ToString("C2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Sindicato(3%): {(salario.GetSalarioBruto()*0.3).ToString("C2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Total de descontos: {(salario.GetIr()+salario.GetInss()).ToString("C2", CultureInfo.CurrentCulture)}");
            Console.WriteLine($"Salario liquido: {salario.GetSalarioLiquido().ToString("C2", CultureInfo.CurrentCulture)}");
            Console.WriteLine("\n\n\nPara encerrar o programa tecle 1, ou qualquer tecla para continuar");
            ushort seletor = 0;
            try{
                seletor = ushort.Parse(Console.ReadLine());
            }catch{
                Console.Clear();
                VerificaSalario();
            }
            if(seletor ==1)
                System.Environment.Exit(0);
            
            VerificaSalario();

        }
        
        static uint GetHorasTrabalhadas(){
            Console.WriteLine("Para prosseguir Insira o numero de horas trabalhadas mensalmente");
            uint hrs= 0;
            try{
                hrs = uint.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor inserido para horas é invalido, pressione qualquer para tentar novamente ");
                Console.ReadKey();
                Console.Clear();
                return GetHorasTrabalhadas();
            }
            return hrs;
        }
        static double GetValorPorHora(){
            Console.Clear();
             Console.WriteLine("Para prosseguir Insira o valor recebido por hora");
            double valorhrs= 0;
            try{
                valorhrs = double.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("O valor inserido para valor por hora é invalido, pressione qualquer para tentar novamente ");
                Console.ReadKey();
                return GetValorPorHora();
            }
            if (valorhrs<0){
                Console.WriteLine("O valor inserido para valor por hora é invalido, pressione qualquer para tentar novamente ");
                Console.ReadKey();
                return GetValorPorHora();
            }
            return valorhrs;
        }     
    }
}