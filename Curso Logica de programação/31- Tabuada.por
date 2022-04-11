programa
{
	inclua biblioteca Tipos -->tp
	funcao tabuada(inteiro num){
		para (inteiro i = 1; i < 10; i++) {
			    escreva(i, "x", num, " =", num*i, "\n")
			}
	}
	funcao inicio()
	{
		cadeia verificador
		inteiro x
		escreva("Opa, me peça a tabuada de um numero\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		x = tp.cadeia_para_inteiro(verificador, 10)
		tabuada(x)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 96; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */