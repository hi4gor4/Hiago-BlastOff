programa
 
{
	// uso da biblioteca tipos para tratar erros de digitacao
	inclua biblioteca Tipos --> tp
	inteiro nota[10]
	inteiro iniciar, meio, fim, busca
	inteiro contA, contB, aux
	logico achado
	cadeia verificador
	funcao inicio()
	{
		para (inteiro i = 0; i < 10; i++) {

			escreva("Insira o valor ",i,":\n")
			leia(verificador)
			enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
				escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
				leia(verificador)
			}
			nota[i] = tp.cadeia_para_inteiro(verificador, 10)
		}	
		para (contA =0 ; contA <= 8; contA++) {
			para (contB = contA + 1; contB <= 9; contB++){
				 se (nota[contA] > nota[contB]){
				 	aux = nota[contA]
					nota[contA] = nota[contB]
					nota[contB] = aux
				 }
			}
		}
		escreva("Qual numero você quer que eu busque?\n")
		leia(verificador)
		enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
			escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
			leia(verificador)
		}
		busca = tp.cadeia_para_inteiro(verificador, 10)
		iniciar = 0 
		fim = 10
		achado = falso
		enquanto( iniciar <= fim e nao achado){
			meio = (iniciar + fim)/2
			se(busca == nota[meio]){
				achado = verdadeiro
				escreva("Achei o ",busca," ele estava na posicao",meio,"\n") 
			}senao se(busca > nota[meio]){
				iniciar = meio +1
			}senao{
				fim = meio -1
			}
		}
		para(inteiro i = 0; i<=9; i++){
			escreva(nota[i],"\n")	
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1276; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */