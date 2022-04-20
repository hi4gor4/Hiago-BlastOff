using System;
using System.Globalization;
namespace Moedas
{
    public class Program
    {
        static void Main(string[] args){
            Console.Clear();
            decimal valor = 10.25m;// primeira opção quando tratamos de moedas
            Console.WriteLine( valor.ToString("C",CultureInfo.CreateSpecificCulture( "pt-Br")));//adapta a moeda ao padrão da cultura usando c // usando P para porcentagem ... etc
            //Biblioteca match
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Round(valor));//arredonda
            Console.WriteLine(Math.Ceiling(valor)); // arredonda pra cima
            Console.WriteLine(Math.Floor(valor));//arredonda para baixo
        }
    }
}