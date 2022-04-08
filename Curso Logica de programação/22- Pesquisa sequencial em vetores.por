programa
 
{
	// uso da biblioteca tipos para tratar erros de digitacao
	inclua biblioteca Tipos --> tp
	inteiro nota[4]
	inteiro a, posicao
	
	cadeia verificador
	funcao inicio()
	{
		para (inteiro i = 0; i < 4; i++) {
			
			escreva("Insira o valor ",i,":\n")
			leia(verificador)
			enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
				escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
				leia(verificador)
			}
			nota[i] = tp.cadeia_para_inteiro(verificador, 10)
		}	
		escreva("Oi você quer saber em que posição está um numero inserido")
		escreva("\n Digite o numero\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		a = tp.cadeia_para_inteiro(verificador, 10)
		posicao = -1
		para (inteiro i = 0; i<=3; i++){
			se(nota[i] == a){
				posicao = i
				escreva("o numero que voce procura está na posicao\n", posicao)			
			}
		}
		se(posicao == -1){
			escreva("Desculpe, não achei seu numero :(")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 938; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */