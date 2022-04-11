programa
{
	inclua biblioteca Util --> ut
	inclua biblioteca Tipos --> tp
	
	
	funcao inicio()
	{
		cadeia verificador
		inteiro x, y
		escreva("Olá, me diga um numero:\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		x = tp.cadeia_para_inteiro(verificador, 10)
		escreva("bom, eu tambem vou escolher um numero\n")
		y = ut.sorteia(0,10)
		escreva("o numero que eu escolhi foi:", y , "\n")
		escreva("se nósa multiplicarmos nossos numeros teremos ", x*y,"\n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 172; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */