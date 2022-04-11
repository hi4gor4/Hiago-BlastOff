programa
{
	inclua biblioteca Tipos --> tp
	
	
	funcao inicio()
	{
		logico a = verdadeiro
		inteiro saldo, cheque
		cadeia verificador
		enquanto(a){	
			
			escreva("Qual é o seu saldo?\n")
			leia(verificador)
			enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
			}
			saldo = tp.cadeia_para_inteiro(verificador, 10)
			
			escreva("Qual é o Valor do cheque que deseja descontar?\n")
			leia(verificador)
			enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
			}
			cheque = tp.cadeia_para_inteiro(verificador, 10)
			se(cheque <= saldo){
				saldo = saldo -cheque
				escreva("O cheque foi descontado, seu saldo é: ", saldo, " \n" )
			}senao{
				escreva("Voce nao tem limite para descontar esse cheque\n")
			}	
			escreva( "Obrigado por nos consultar.\n") 

			escreva("para fazer outra consulta tecle 1, ou qualquer outra para sair\n\n")
			leia(verificador)
			se(verificador != "1"){
				a= falso
				
			}
			
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 860; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */