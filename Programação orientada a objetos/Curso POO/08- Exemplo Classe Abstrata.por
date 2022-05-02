Classe Animal
{
	privado inteiro idade
	privado real peso
	privado cadeia tipo
	publico funcao emitir som()
	publico funcao tipodepele()
	

}
Classe Cachorro estende Animal{
	privado inteiro idade
	privado real peso
	privado cadeia tipo

	publico construtor(inteiro aidade, real apeso){
		tipo = "Domestico"
		idade = aidade
		peso = apeso
	}
	
	publico funcao emitir som(){
		retorne "ruf ruf ruf"
	}
	publico funcao tipodepele(){
		retorne "pelo"
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