programa
{
	
cadeia aprova
	inteiro num
	funcao inicio()
	{
		escreva("Quer que eu te ensine a contar até 100?\n")
		escreva("Digite sim para aceitar ...\n")
		leia(aprova)
		num = 0
		se (aprova == "sim"){
			faca{
				escreva(num,"\n")
				num = num + 1
			}enquanto (num <= 100)
		}senao{
			escreva("que pena, te vejo na proxima")
		}
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 164; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */