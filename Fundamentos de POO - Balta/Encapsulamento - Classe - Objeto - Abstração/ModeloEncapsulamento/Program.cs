using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cst  = new Customer("Hiago"); 
        }
    }
    internal class Customer{// classe são valores de referencia --- composto de propriedades metodos e eventos
        //->Endereço dos dados

        private string nome;
        public Customer(string nome){
            this.nome= nome;
        }

    }
}