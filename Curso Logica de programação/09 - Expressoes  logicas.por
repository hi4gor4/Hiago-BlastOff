programa
 
{
	// uso da biblioteca tipos para tratar erros de digitacao
	inclua biblioteca Tipos --> tp
	
inteiro a, b, c
	cadeia verificador
	funcao inicio()
	{
		
		escreva("Insira o numero a:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		a = tp.cadeia_para_inteiro(verificador, 10)
		
		escreva("Insira o numero b:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro :\n")
			leia(verificador)
		}
		b = tp.cadeia_para_inteiro(verificador, 10)
		escreva("Insira o numero c:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro :\n")
			leia(verificador)
		}
		c = tp.cadeia_para_inteiro(verificador, 10)
		se (b == a e b ==c){
			escreva("todos os numeros são iguais")			
		}senao se (b > a e b > c ){
			escreva("b é o maior numero")
		}senao {
			escreva("b não é o maior numero")
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1053; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */