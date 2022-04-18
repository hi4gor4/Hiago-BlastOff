programa
{
	inclua biblioteca Tipos --> tp
	
	
	funcao inicio()
	{
		logico a = verdadeiro
		inteiro salario, financiamento
		cadeia verificador, nome
		enquanto(a){	
			
			escreva("Qual é o seu nome \n")
			leia(nome)
			
			escreva("Qual é o seu salario?\n")
			leia(verificador)
			enquanto (nao tp.cadeia_e_inteiro(verificador, 10)){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
			}
			salario = tp.cadeia_para_inteiro(verificador, 10)
			
			escreva("Qual é o Valor que deseja financiar?\n")
			leia(verificador)
			enquanto (nao tp.cadeia_e_inteiro(verificador, 10) ){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
			}
			financiamento = tp.cadeia_para_inteiro(verificador, 10)
			se(financiamento >= salario*5){
				escreva(nome,"o seu Financiamento foi concedido\n")
			}senao{
				escreva(nome,"o seu Financiamento Negado\n")
			}	
			escreva( "Obrigado por nos consultar.\n") 

			escreva("para fazer outra consulta tecle 1, ou qualquer outra para sair\n\n")
			leia(verificador)
			a = verificador == "1"
			
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1132; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */