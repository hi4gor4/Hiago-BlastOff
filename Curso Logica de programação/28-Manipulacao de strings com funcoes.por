programa
{
	inclua biblioteca Texto --> tx
	
	funcao inicio()
	{
		cadeia data
		cadeia dia, mes, ano
		logico a = verdadeiro
		enquanto (a){		
			escreva("me diga a data de hoje no formato dd/mm/aaaa\n")
			leia(data)
			se (tx.numero_caracteres(data) >= 10){
				dia = tx.extrair_subtexto(data, 0, 2)
				mes = tx.extrair_subtexto(data, 3, 5)
				ano = tx.extrair_subtexto(data, 6, 10)
				escreva("o dia é : ", dia ," \n")
				escreva("o mes é : ", mes ," \n")
				escreva("o ano é : ", ano ," \n")
				a = falso
			}senao{
				escreva("xi cara eu não entendi, vamos tentar de novo\n")
			}
		}	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 600; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */