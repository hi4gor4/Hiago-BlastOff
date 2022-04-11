programa
{
	
	inclua biblioteca Tipos -->tp
	funcao inicio()
	{
		logico a = verdadeiro
		cadeia verificador,nome
		inteiro x
		enquanto(a){
			escreva("Digite o nome do funcionario:\n")
			leia(nome)
			escreva("Para saber o salario de ",nome," diga seu nome quantos sistemas ele vendeu\n")
			leia(verificador)
			enquanto (tp.cadeia_e_inteiro(verificador, 10) == falso){
				escreva("O numero que você digitou foi invalido \nInsira um numero inteiro:\n")
				leia(verificador)
			}
			x = tp.cadeia_para_inteiro(verificador, 10)
			escreva("\n\n\nO salario de", nome, "é de ", 500+ (x*50), " este mês\n")

			escreva("Para sair do sistema tecle 1, ou qualquer tecla para continuar ")
			leia(verificador)
			se(verificador == "1"){
				a = falso
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