using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void RealizarPagamento(double valor){
            Console.WriteLine(valor);
        }
        static void Main(string[] args)
        {
            var pagamento = new Pagamento.Pagar(RealizarPagamento);//Derlega a finção realizar pagamento para fazer a função do Pagar
        }
    }
}