classe Controle implementa controlador
{
	privado inteiro volume
	privado logico ligado
	privado logico tocando
	publico funcao contrutor()
	{
		volume = 50
		tocando = falso
		ligado = falso
	}
	publico inteiro funcao  getVolume(){
		retorne volume
	}
	publico funcao  setvolume(inteiro avolume){
		volume = avolume
	}	
		
	publico inteiro funcao  getTocando(){
		retorne tocando
	}
	publico funcao  setTocando(logico atocando){
		tocando = atocando
	}

	publico funcao  setLigado(logico aligado){
		ligado = aligado
	}
	
	publico inteiro funcao  getLigado{
		retorne ligado
	}	

	
	publico   funcao ligar_desligar(){
		se(getLigado){
			setLigado(falso)
		}senao{
			setLigado = verdadeiro
		}
		
	}
	
	
	publico   funcao abrirMenu(){
		setTocando(falso)
	}
	publico  funcao fecharMenu(){
		setTocando(verdadeiro)
	}
	publico  funcao aumentarVolume(){
		se(getVolume() < 100 e getLigado(){
			setVolume(getVolume()+1)
		}
	}
	publico   funcao diminuirVolume(){
		se(volume >0 e getLigado(){
			setVolume(getVolume()-1)
		}
	}
	publico abstrato  funcao tornarMudo(){
		se(volume >0 e getLigado(){
			setVolume(0)
		}
	}
	publico abstrato  funcao desligarMudo(){
		se(volume == 0 e getLigado(){
			setVolume(50)
		}
	}
	publico abstrato  funcao pausar(){
		se(getTocando() e getLigado(){
			setTocando(falso)
		}senao se(getLigado()){
			setTocando(verdadeiro)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1366; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */