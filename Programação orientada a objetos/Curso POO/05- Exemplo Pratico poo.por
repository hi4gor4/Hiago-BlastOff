classe ContaBanco{
	publico inteiro numero_Conta
	protegido cadeia tipo
	privado cadeia dono
	privado real saldo
	privado logico status 
	publico funcao construtor(cadeia adono){
		dono = adono
		saldo = 0
		status = falso
		
	}
	publico funcao inteiro getNumeroConta(){
		retorne numero_conta
	}
	publico funcao setNumeroConta(inteiro aNumeroConta){
		Numero_Conta = aNumeroConta
	}
	publico funcao real getSaldo(){
		retorne saldo
	}
	publico funcao cadeia getTipo(){
		retorne tipo
	}
	protegido funcao setTipo(cadeia atipo){
		tipo = atipo
	}
	publico funcao cadeia getDono(){
		retorne dono
	}
	publico logico getStatus(){
		retorne status
	}
	private logico setStatus(){
		retorne status
	}
	publico funcao abrirConta(cadeia atipo){
		
		se (tipo == "cp"){
			saldo = 50
			setTipo(atipo)
			setStatus(verdadeiro)
		}senao se(tipo ==  "cc"){
			saldo = 100
			setTipo(atipo)
			setStatus(verdadeiro)
		}senao{
			escreva("tipo invalido!")
		}
		
	}
	publico logico funcao fecharConta(){
		se(saldo > 0){
			escreva("voce ainda tem dinheiro em conta")
			retorne falso
		}senao se(saldo < 0){
			escreva("sua conta ainda está em debito")
			retorne falso
		}
		setStatus(falso)
		retorne verdadeiro
	}

	publico logico deposito(real valor){
		se (getStatus() e valore > 0){
			saldo = saldo + valor
			retorne verdadeiro 
		}
		retorne falso
	}
	publico logico sacar(real valor){
		se (getStatus() e saldo > valor ){
			saldo = saldo - valor
			retorne verdadeiro 
		}
		retorne falso
	}		

	
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1412; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */