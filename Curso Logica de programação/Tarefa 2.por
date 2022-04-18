programa
{
	inclua biblioteca Tipos --> tp
	
	
	funcao inicio()
	{
		logico a = verdadeiro
		inteiro km_saida, km_chegada, trajeto
		real gasolina_usada
		cadeia verificador
		enquanto(a){
			escreva("Olá como foi de viagem?\n")
			leia(verificador)	
			
			escreva("Qual foi a sua quilometragem na saida?\n")
			leia(verificador)
			enquanto (nao tp.cadeia_e_inteiro(verificador, 10) ){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
			}
			km_saida = tp.cadeia_para_inteiro(verificador, 10)
			
			escreva("Qual foi a sua quilometragem na chegada?\n")
			leia(verificador)
			enquanto (nao tp.cadeia_e_inteiro(verificador, 10) ){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
			}
			km_chegada = tp.cadeia_para_inteiro(verificador, 10)
			se(km_saida >= km_chegada){
				escreva("desculpe, nao consegui definir o seu trajeto\n")
			}senao{
				trajeto = km_chegada - km_saida
				escreva("Qual foi a quantidade de  gasolina usada na viagem?\n")
				leia(verificador)
				enquanto (nao tp.cadeia_e_real(verificador) e tp.cadeia_para_real(verificador) > 0){
					escreva("O numero que você digitou foi invalido \nInsira um numero real:\n")
					leia(verificador)
				}
				gasolina_usada = tp.cadeia_para_real(verificador)
				escreva("\n\n\n O seu trajeto foi de ", trajeto," kilometros\n")
				escreva(" O seu consumo medio de combustivel foi de ", trajeto/gasolina_usada," km por litro\n")

				escreva("para fazer outra viagem tecle 1, ou qualquer outra para sair\n\n")
				leia(verificador)
				a = verificador == "1"

				
			}
			
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 10; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */