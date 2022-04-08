programa
 
{
	// uso da biblioteca tipos para tratar erros de digitacao
	inclua biblioteca Tipos --> tp
	inteiro nota[4]
	
	real media
	cadeia verificador
	funcao inicio()
	{
		media = 0
		para (inteiro i = 0; i < 4; i++) {

			escreva("Insira a nota ",i,":\n")
			leia(verificador)
			enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
				escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
				leia(verificador)
			}
			nota[i] = tp.cadeia_para_inteiro(verificador, 10)
		}	
		para (inteiro i = 1; i < 4; i++) {
    			media = media + nota[i]
		}
		media = media/4
		
		se (media >= 7){
			escreva("\n\n\nVoce foi aprovado \n\n\n")			
		}senao se(media >=3){
			escreva("\n\n\nVoce está na recuperação \n\n\n")
		}senao{
			escreva("\n\n\nVocê foi reprovado\n\n\n")
		}
		escreva("Sua media é de :", media)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 777; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */