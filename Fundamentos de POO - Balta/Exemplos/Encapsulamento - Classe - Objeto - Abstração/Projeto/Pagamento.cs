using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class pagamento
    {
        //encapusulamento, juntar as coisas que tem sentido em ficarem juntas separando em partes 
        //separar variaveis em propriedades
        //abstração - esconder detalhes que não precisam ser mostrados externamente
        //por exemplo um inretuptor abstrai o corte de energia que acontece, deixando aparente apenas a auteraçãqo de esttado das coisas
 
        public DateTime vencimento;// Faz sentido verificar externamente?sim

        void Pagar(){

        }
        private void consultarSaldoCartao(){//Faz sentido mostrar externamente? Não - então é abstraido do resto do programa

        }
    }
}