using System;

namespace HerancaModelo // Note: actual namespace depends on the project name.
{
    class PagamentoBoleto: Pagamento
    {
        public PagamentoBoleto(string nome)
        {
        //atalho ctor cria construtor
        //a chamada do construtor usando a palavra reservada new gera uma nova instancia da classe
        //executado na instancia da classe
        }
        public string nomeBoleto = "";

        public override void Pagar()
        {
        //override permite sobrescrever o metodo da classe pai, usando ele de maneira diferente no pagamento boleto
            nomeBoleto = "pago"; // traz novas informações e pode manter sua base
            base.Pagar();
        }
        public override string ToString()// o metodo to strint é sempre um virtual
        {
            return Vencimento.ToString("dd,mm,aaaa");
        }


    }
}