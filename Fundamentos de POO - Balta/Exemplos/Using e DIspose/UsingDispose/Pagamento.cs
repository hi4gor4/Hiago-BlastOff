using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Pagamento : IDisposable//Implementa uma interface
    {
        //Garbage Collector -> Gerencia o uso de memoria
        //Criar e destruir um objeto
        public Pagamento()//cria uma instancia de construtor
        {
           Console.WriteLine("Iniciando pagamento"); 
        }
        public void Dispose()
        {
            Console.WriteLine("Finalizando o pagamento");
        }
    }
}