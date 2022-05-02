using System;

namespace HerancaModelo // Note: actual namespace depends on the project name.
{
    internal class Pagamento// possivel de ver no mesmo namespace
    {
        //Modificadores de Acesso private, public, internal e protect
        // Private visivel apenas no escopo da classe
        // propriedades
        public int MyProperty { get; set; }// prop> cria uma propriedade
        //get e set são acessores para atribuir ou ler valores
        public int MyPropertyPriv { get; private set; }// propg> cria uma propriedade com ge public e set privado 
        private int myVar;
        public int MyPropertyFull
        {
            get //sempre retorna um valor
            {
                //permite interações com o conteudo
                return myVar; 
            }
            set { 
                myVar = value;//atribui um novo valor usando value como referencia 
            }
        }
        
        public DateTime Vencimento;

        private string nome = "";//visivel apenas no escopo da classe
        protected string nome2 = ""; // protected é visualizavel pelas classes filhas
        public virtual void Pagar(){
        //virtual>permite que o metodo possa ter outras formas
        // public pode ser visto de qualquer escopo

        }
        public virtual void Pagar(bool bl = false){
        // pode ter mais que uma forma se comportando de maneira diferente> chamada de sobrecarga de metodo
        //virtual>permite que o metodo possa ter outras formas sendo assim sobrescrito
        // public pode ser visto de qualquer escopo
        //quando um parametro do metodo tem seu valor atribuido a exemplo da bl, ela se torna um parametro opcional, caso não seja atribuido a ele um valor, então o mesmo tera o valor de definiçã
        
        }
    }
}