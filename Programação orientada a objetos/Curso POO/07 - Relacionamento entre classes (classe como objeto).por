classe lutador
{
	privado cadeia nome
	privado real peso
	privado cadeia categoria

	publico funcao contrutor(cadeia anome, real apeso){
		nome = aNome
		peso = aPeso
		setCategoria(apeso)
	}
		
	publico cadeia funcao  getNome(){
		retorne nome
	}
	publico funcao  setNome(cadeia anome){
		nome = anome
	}	
		
	publico real funcao  getPeso(){
		retorne peso
	}
	publico funcao  setPeso(real aPeso){
		peso = aPeso
		setCategoria(aPeso)
	}	
		
	publico cadeia funcao  getVolume(){
		retorne categoria
	}
	publico funcao  setCategoria (real apeso){
		se(peso < 52.3){
			categoria = "invalido"
		}senao se(peso <72.3){
			categoria = "leve"
		}senao{
			categoria = "pesado"
		}
	}	
	publico funcao apresentar()
	{
		escreva(getNome()," pesando ", getPeso(), "sobe ao ringue para a luta\n")
	}
}
programa
{
	lutador lutadores[5]  
	funcao inicio()
	{
		lutador[0] = novo lutador("Hiago", 54.5)
		lutador[1] = novo lutador("Hiure", 75.3)
		...
		lutador[0].apresentar()
		lutador[1].apresentar()
	}
}

/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 791; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */