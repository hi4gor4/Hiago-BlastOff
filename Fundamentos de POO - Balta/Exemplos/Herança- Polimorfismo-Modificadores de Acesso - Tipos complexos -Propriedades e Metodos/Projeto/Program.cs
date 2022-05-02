using System;

namespace HerancaModelo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pag = new PagamentoBoleto("Hiago");// gera a instancia de um novo pagamento boleto, chamndo sua função construtora
            pag.Pagar();
            Console.WriteLine( pag.Vencimento);// metodos e atributossão acessiveis graças a herança
            pag.nomeBoleto = "QF";// e pode trazer novas informações
            Console.WriteLine(pag.ToString());
            //c# não traz a herança multipla como uma opção
        }
    }
}