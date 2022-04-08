programa
{
	inclua biblioteca Tipos --> tp
	inteiro x, y, aux
	cadeia verificador
	funcao inicio()
	{
		escreva("Insira o valor de x:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		y = tp.cadeia_para_inteiro(verificador, 10)	
		escreva("Insira o valor de y:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		x = tp.cadeia_para_inteiro(verificador, 10)	
		escreva("O valor de x é de ", x, " e o de y é de ", y,"?\n")
		escreva("digite nao caso não seja\n")
		leia(verificador)
		se(verificador == "nao"){
			escreva("desculpa cara eu me confundi, vamos corrigir isso\n")
			aux = x
			x = y
			y = x
			escreva("O valor de x é de ", x, " e o de y é de ", y,"\n")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 862; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */