programa
{
	//variaveis
	inteiro n1, n2, n3, n4
	cadeia resposta
	inteiro media
	
	
	funcao inicio()
	{
		escreva("Digite suas medias\n")
		leia(n1, n2, n3, n4)
		media = (n1+n2+n3+n4)/4
		se (media>=7){
			resposta = "aprovado"
		}senao{
			resposta = "reprovado"
		}
		escreva(resposta)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 140; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */