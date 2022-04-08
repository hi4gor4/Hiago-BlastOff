programa
 
{
	// uso da biblioteca tipos para tratar erros de digitacao
	inclua biblioteca Tipos --> tp
	
	inteiro a, b, c, d 
	inteiro media
	cadeia verificador
	funcao inicio()
	{
		
		escreva("Insira a primeira nota:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso e tp.cadeia_para_inteiro(verificador, 10) > 10 ){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		a = tp.cadeia_para_inteiro(verificador, 10)
		
		escreva("Insira a sua segunda nota:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro :\n")
			leia(verificador)
		}
		b = tp.cadeia_para_inteiro(verificador, 10)
		escreva("Insira a sua terceira nota:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro :\n")
			leia(verificador)
		}
		c = tp.cadeia_para_inteiro(verificador, 10)
		escreva("Insira a sua quarta nota:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro :\n")
			leia(verificador)
		}
		d = tp.cadeia_para_inteiro(verificador, 10)
		media = (a+b+c+d) / 4
		escolha(media){
			caso 0: 
				escreva("xiiiii voce tirou a nota minima")
				pare
			caso 7:
				escreva("aprovado na bacia das almas")
				pare
			caso 10:
				escreva("eu achava que ninguem era perfeito antes de conhecer você")		
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1606; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */