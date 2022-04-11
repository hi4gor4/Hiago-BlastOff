programa
{
	inclua biblioteca Tipos -->tp
	funcao inteiro fibonacci(inteiro num){
		se(num ==1 ){
			retorne 1
		}senao se (num == 2){
			retorne 1
		}senao{
			retorne fibonacci(num -1) + fibonacci(num-2)
		}
			
		
	}
		
	funcao inicio()
	{
		cadeia verificador
		inteiro x
		escreva("Opa, me diga qual numero da sequencia de fibonacci voce quer\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		x = tp.cadeia_para_inteiro(verificador, 10)
		escreva("o numero ", x ,"da sequencia de fibonacci é ", fibonacci(x), " \n")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 362; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */