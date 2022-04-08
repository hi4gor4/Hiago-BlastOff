programa
 
{
	// uso da biblioteca tipos para tratar erros de digitacao
	inclua biblioteca Tipos --> tp
	inteiro nota[3][4]
	
	real media
	cadeia verificador
	funcao inicio()
	{
		media = 0
		para(inteiro j = 0; j < 3; j++){
			para (inteiro i = 0; i < 4; i++) {
	
				escreva("Insira a nota ",i," do aluno ",j," :\n")
				leia(verificador)
				enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso ou6 tp.cadeia_para_inteiro(verificador, 10) > 10 ){
					escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
					leia(verificador)
				}
				nota[j][i] = tp.cadeia_para_inteiro(verificador, 10)
			}	
		}

		para(inteiro j = 0; j < 3; j++){
			escreva("As notas do aluno",j,"são:")
			para (inteiro i = 0; i < 4; i++) {
				escreva(nota[j][i],"  ") 
				media = media + nota[j][i]	
			}
			media = media/4
			escreva(" e sua media é de ", media," ele ")
			se (media >= 7){
				escreva("foi aprovado \n\n\n")			
			}senao se(media >=3){
				escreva(" está na recuperação \n\n\n")
			}senao{
				escreva(" foi reprovado\n\n\n")
			}
			media = 0
		}	
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 404; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */