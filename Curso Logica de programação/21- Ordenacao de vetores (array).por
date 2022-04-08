programa
 
{
	// uso da biblioteca tipos para tratar erros de digitacao
	inclua biblioteca Tipos --> tp
	inteiro nota[4]
	inteiro contA, contB,aux
	
	cadeia verificador
	funcao inicio()
	{
		para (inteiro i = 0; i < 4; i++) {

			escreva("Insira o valor ",i,":\n")
			leia(verificador)
			enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
				escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
				leia(verificador)
			}
			nota[i] = tp.cadeia_para_inteiro(verificador, 10)
		}	
		para (contA =0 ; contA <= 2; contA++) {
			para (contB = contA + 1; contB <= 3; contB++){
				 se (nota[contA] > nota[contB]){
				 	aux = nota[contA]
					nota[contA] = nota[contB]
					nota[contB] = aux
				 }
			}
		}
		para(inteiro i = 0; i<=3; i++){
			escreva(nota[i],"\n")	
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 71; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */